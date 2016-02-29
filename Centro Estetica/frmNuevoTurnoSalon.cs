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
    public partial class frmNuevoTurnoSalon : Form
    {
        int dia = 0;
        public frmNuevoTurnoSalon(string fe, int d, string hora)
        {
            InitializeComponent();
            txtFecha.Text = fe;
            dia = d;
            txtHora.Text = hora;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = DateTime.Parse(txtHora.Text);
                DateTime egreso = inicio.AddHours(Convert.ToInt32(txtDuracion.Text));
                Acceso_BD oacceso = new Acceso_BD();
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                DataTable dt = oacceso.leerDatos("select 'turno ya cargado' as ok from turnossalon where ingreso > '" + inicio.ToString("HH:mm") + "' and ingreso < '" + egreso.ToString("HH:mm") + "' and dia = '" + dia + "' and fecha = '" + fecha.ToString("yyyy-MM-dd") + "' or (egreso > '" + inicio.ToString("HH:mm") + "' and egreso < '" + egreso.ToString("HH:mm") + "' and dia = '" + dia + "' and fecha = '" + fecha.ToString("yyyy-MM-dd") + "')");
                string ok = "";
                foreach(DataRow dr in dt.Rows)
                {
                    ok = Convert.ToString(dr["ok"]);
                }
                if (!ok.Equals("turno ya cargado"))
                {
                    oacceso.ActualizarBD("insert into turnossalon (nombre, telefono, celular, fecha, ingreso, egreso, cantidad, dia) values ('" + txtNombre.Text + "','" + txtTelefono.Text + "','" + txtCelular.Text + "','" + fecha.ToString("yyyy-MM-dd") + "','" + inicio.ToString("HH:mm") + "','" + egreso.ToString("HH:mm") + "','" + txtDuracion.Value + "','" + dia + "')");
                    MessageBox.Show("Turno guardado exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Imposible guardar turno, horario ocupado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
