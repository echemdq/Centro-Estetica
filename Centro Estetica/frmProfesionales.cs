using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class frmProfesionales : Form
    {
        ControladoraTipoDoc ctip = new ControladoraTipoDoc();
        ControladoraProfesionales cprof = new ControladoraProfesionales();
        public frmProfesionales()
        {
            InitializeComponent();
        }

        private void frmProfesionales_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.DataSource = ctip.TraerTodos();
            cmbTipoDoc.DisplayMember = "detalle";
            cmbTipoDoc.ValueMember = "idtipodoc";
            cmbTipoDoc.SelectedIndex = 0;
        }
        public void deshabilitar()
        {
            txtDocumento.Enabled = false;
            txtDomicilio.Enabled = false;
            txtMail.Enabled = false;
            txtProfesional.Enabled = false;
            txtTelefono.Enabled = false;
            btnSubrubros.Enabled = false;
            btnHorarios.Enabled = false;
        }
        public void habilitar()
        {
            txtDocumento.Enabled = true;
            txtDomicilio.Enabled = true;
            txtMail.Enabled = true;
            txtProfesional.Enabled = true;
            txtTelefono.Enabled = true;
            btnSubrubros.Enabled = true;
            btnHorarios.Enabled = true;
        }
        public void limpiar()
        {
            txtDocumento.Text = "";
            txtDomicilio.Text = "";
            txtMail.Text = "";
            txtProfesional.Text = "";
            txtTelefono.Text = "";
            lblId.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
            btnSubrubros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                deshabilitar();
                limpiar();
                frmBuscaProfesionales frm = new frmBuscaProfesionales();
                frm.ShowDialog();
                Profesionales u = frm.u;
                if (u != null)
                {
                    lblId.Text = Convert.ToString(u.Idprofesionales);
                    txtProfesional.Text = u.Profesional;
                    txtDocumento.Text = u.Documento;
                    txtDomicilio.Text = u.Domicilio;
                    txtTelefono.Text = u.Telefono;
                    txtMail.Text = u.Mail;
                    cmbTipoDoc.Text = u.Tipod.Detalle;
                    if (u.Activo == 0)
                    {
                        chkActivo.Checked = false;
                        //tabPageCargaEmpleados.BackColor = Color.LightCoral;
                    }
                    else if (u.Activo == 1)
                    {
                        chkActivo.Checked = true;
                        //tabPageCargaEmpleados.BackColor = SystemColors.Info;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProfesional.Text != "")
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
                    Profesionales r = new Profesionales(0, txtProfesional.Text, txtDocumento.Text, tip, txtDomicilio.Text, txtTelefono.Text, txtMail.Text, activo);
                    if (lblId.Text == "")
                    {
                        cprof.Agregar(r);
                        MessageBox.Show("Profesional guardado correctamente");
                    }
                    else
                    {
                        r.Idprofesionales = Convert.ToInt32(lblId.Text);
                        cprof.Modificar(r);
                        MessageBox.Show("Profesional modificado correctamente");
                    }
                    limpiar();
                    deshabilitar();
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre y apellido del Profesional");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "")
                {
                    Profesionales r = new Profesionales(Convert.ToInt32(lblId.Text), "", "", null, "", "", "", 0);
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el profesional: "+ txtProfesional.Text, "Eliminar Profesional", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cprof.Borrar(r);
                        limpiar();
                        deshabilitar();
                        MessageBox.Show("Profesional eliminado correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Profesional para eliminarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                habilitar();
            }
        }

        private void btnSubrubros_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                frmSubrubrosProf frm = new frmSubrubrosProf(lblId.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un profesional para ir a la configuracion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                frmHorariosProfesionales frm = new frmHorariosProfesionales(lblId.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un profesional para ir a la configuracion");
            }
        }
    }
}
