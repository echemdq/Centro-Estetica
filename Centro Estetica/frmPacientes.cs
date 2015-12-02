using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Imaging;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.ComponentModel;

namespace Centro_Estetica
{
    public partial class frmPacientes : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        ControladoraPacientes cpac = new ControladoraPacientes();
        ControladoraTipoDoc ctip = new ControladoraTipoDoc();
        public frmPacientes()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbFotoUser.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (ExistenDispositivos)
            {
                FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                FuenteDeVideo.Start();
                cboDispositivos.Enabled = false;
            }
            else
                MessageBox.Show("Error: No se encuentra dispositivo.");
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TerminarFuenteDeVideo();
            pbFotoUser.ImageLocation = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var fileName = String.Empty;
            try
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                }
                if (pbFotoUser.Image != null)
                {
                    using (var dlg = new SaveFileDialog())
                    {
                        dlg.FileName = txtPaciente.Text + " " + txtDocumento.Text;

                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select detalle from configuraciones where codigo = 'fotos'");

                        foreach (DataRow dr in dt.Rows)
                        {
                            dlg.InitialDirectory = Convert.ToString(dr["detalle"]);
                        }
                        dlg.DefaultExt = "png";
                        dlg.Filter = "PNG Files (*.png)|*.png|SVG Files (*.svg)|*.svg|BMP Files (*.bmp)|*.bmp|TIFF Files (*.tif)|*.tif|JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                        if (dlg.ShowDialog(this) != DialogResult.OK)
                            return;
                        fileName = dlg.FileName;
                    }
                    var extension = Path.GetExtension(fileName).ToLower();
                    var bmp = (Bitmap)pbFotoUser.Image;
                    switch (extension)
                    {
                        case ".bmp":
                            bmp.Save(fileName, ImageFormat.Bmp);
                            break;
                        case ".jpeg":
                        case ".jpg":
                            bmp.Save(fileName, ImageFormat.Jpeg);
                            break;
                        case ".tiff":
                        case ".tif":
                            bmp.Save(fileName, ImageFormat.Tiff);
                            break;
                        default:
                            bmp.Save(fileName, ImageFormat.Png);
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pbFotoUser.Refresh();
                pbFotoUser.ImageLocation = fileName;
                lbl_foto.Text = fileName;
            }
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.DataSource = ctip.TraerTodos();
            cmbTipoDoc.DisplayMember = "detalle";
            cmbTipoDoc.ValueMember = "idtipodoc";
            cmbTipoDoc.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
        }
        public void deshabilitar()
        {
            btnIniciar.Enabled = false;
            btnDetener.Enabled = false;
            btnCaptura.Enabled = false;
            txtCelular.Enabled = false;
            txtComentarios.Enabled = false;
            txtDocumento.Enabled = false;
            txtDomicilio.Enabled = false;
            txtMail.Enabled = false;
            txtPaciente.Enabled = false;
            txtTelefono.Enabled = false;
        }
        public void habilitar()
        {
            btnIniciar.Enabled = true;
            btnDetener.Enabled = true;
            btnCaptura.Enabled = true;
            txtCelular.Enabled = true;
            txtComentarios.Enabled = true;
            txtDocumento.Enabled = true;
            txtDomicilio.Enabled = true;
            txtMail.Enabled = true;
            txtPaciente.Enabled = true;
            txtTelefono.Enabled = true;
        }
        public void limpiar()
        {
            txtCelular.Text = "";
            txtComentarios.Text = "";
            txtDocumento.Text = "";
            txtDomicilio.Text = "";
            txtMail.Text = "";
            txtPaciente.Text = "";
            txtTelefono.Text = "";
            lbl_foto.Text = "";
            lblId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaciente.Text != "")
                {
                    int activo = 1;
                    if (!chkActivo.Checked)
                    {
                        activo = 0;
                    }
                    else
                    {
                        activo = 1;
                    }
                    TipoDoc tip = new TipoDoc(Convert.ToInt32(cmbTipoDoc.SelectedValue), "");
                    Pacientes r = new Pacientes(0, txtPaciente.Text, txtTelefono.Text, txtDomicilio.Text, txtMail.Text, txtDocumento.Text, tip, txtCelular.Text, activo, txtComentarios.Text, lbl_foto.Text);
                    if (lblId.Text == "")
                    {
                        cpac.Agregar(r);
                        MessageBox.Show("Paciente guardado correctamente");
                    }
                    else
                    {
                        r.Idpacientes = Convert.ToInt32(lblId.Text);
                        cpac.Modificar(r);
                        MessageBox.Show("Paciente modificado correctamente");
                    }
                    limpiar();
                    deshabilitar();
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre y apellido del paciente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }
    }
}
