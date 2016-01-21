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
    public partial class frmDatosTurno : Form
    {
        int idt = 0;
        string pac = "";
        Servicios serv = null;
        string fec = "";
        DateTime fechaa;
        int idserviciosturnos = 0;
        int idservicios = 0;
        int asistencia = 0;
        Turnos t = null;
        ControladoraTurnos controlt = new ControladoraTurnos();
        Acceso_BD oacceso = new Acceso_BD();
        public frmDatosTurno(int idturnos, string paciente, string fecha)
        {
            InitializeComponent();
            idt = idturnos;
            pac = paciente;
            fec = fecha;
            fechaa = Convert.ToDateTime(fecha);
        }

        private void frmDatosTurno_Load(object sender, EventArgs e)
        {
            t = controlt.Buscar(idt.ToString());
            txtProfesional.Text = t.Profesionales.Profesional;
            txtTelefono.Text = t.Telefono;
            txtDetalle.Text = t.Detalle;
            txtFecha.Text = fec;
            txtHora.Text = t.Hora;
            txtPaciente.Text = pac;
            DataTable dt = oacceso.leerDatos("select st.asistencia as asistencia, st.idserviciosturnos as idservt, s.detalle as detalle, st.idservicios as idservicios from serviciosturnos st inner join servicios s on st.idservicios = s.idservicios where st.fecha = '"+fechaa.ToString("yyyy-MM-dd")+"' and st.hora = '"+t.Hora+"' and st.idprofesionales = '"+t.Profesionales.Idprofesionales+"' and st.idpacientes = '"+t.Paciente+"'");
            
            foreach (DataRow dr in dt.Rows)
            {
                idserviciosturnos = Convert.ToInt32(dr["idservt"]);
                idservicios = Convert.ToInt32(dr["idservicios"]);
                txtProducto.Text = Convert.ToString(dr["detalle"]);
                asistencia = Convert.ToInt32(dr["asistencia"]);
            }
            if (idserviciosturnos == 0 && fechaa >= DateTime.Now.Date)
            {
                btnAgregarServ.Enabled = true;
            }
            else if (idserviciosturnos != 0 && fechaa >= DateTime.Now.Date)
            {
                btnEliminarServ.Enabled = true;                
            }

            if (idserviciosturnos != 0 && fechaa == DateTime.Now.Date)
            {
                btnGuardar.Visible = true;
            }

            if (asistencia == 1)
            {
                btnAgregarServ.Enabled = false;
                btnEliminarServ.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnEliminarServ_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProducto.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el Servicio del turno?", "Eliminar Servicio del Turno", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        oacceso.ActualizarBD("start transaction; delete from serviciosturnos where idserviciosturnos = '"+idserviciosturnos+"'; update servicios set usadas = usadas - 1 where idservicios = '"+idservicios+"'; commit;");
                        MessageBox.Show("Servicio eliminado correctamente");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarServ_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProducto.Text == "")
                {
                    frmBuscaServicio frm = new frmBuscaServicio(t.Paciente);
                    frm.ShowDialog();
                    serv = frm.u;
                    if (serv != null)
                    {
                        txtProducto.Text = serv.Detalle;
                        DialogResult dialogResult = MessageBox.Show("Esta seguro de Agregar el Servicio del turno?", "Agregar Servicio del Turno", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            DataTable dt = oacceso.leerDatos("start transaction; insert into serviciosturnos (idprofesionales, idservicios, fecha, hora, idpacientes) values ('" + t.Profesionales.Idprofesionales + "','" + serv.Idservicios + "','" + fechaa.ToString("yyyy-MM-dd") + "','" + t.Hora + "','" + t.Paciente + "'); update servicios set usadas = usadas + 1 where idservicios = '" + serv.Idservicios + "'; select max(idserviciosturnos) as idservt from serviciosturnos; commit;");
                            foreach (DataRow dr in dt.Rows)
                            {
                                idserviciosturnos = Convert.ToInt32(dr["idservt"]);
                            }
                            MessageBox.Show("Servicio agregado correctamente");
                            idservicios = serv.Idservicios;
                            if (fechaa == DateTime.Now.Date)
                            {
                                btnGuardar.Visible = true;
                            }
                            btnEliminarServ.Enabled = true;
                            btnAgregarServ.Enabled = false;
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de confirmar asistencia al turno?", "Asistencia al turno", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    oacceso.ActualizarBD("update serviciosturnos set asistencia = 1 where idserviciosturnos = '"+idserviciosturnos+"'");
                    MessageBox.Show("Asistencia Confirmada");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
