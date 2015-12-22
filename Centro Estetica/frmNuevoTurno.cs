using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Centro_Estetica
{
    public partial class frmNuevoTurno : Form
    {
        ControladoraProfesionales controlp = new ControladoraProfesionales();
        public frmNuevoTurno(string fecha, string hora, string profesional)
        {
            InitializeComponent();
            txtFecha.Text = fecha;
            txtHora.Text = hora;
            txtProfesional.Text = profesional;
            Profesionales p = controlp.Buscar(profesional);
            lblIdProf.Text = p.Idprofesionales.ToString();
            DateTime dia = Convert.ToDateTime(fecha);
            int diaint = Convert.ToInt32(dia.DayOfWeek);
        }

        private void chkFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFijo.Checked)
            {
                rbQuincenal.Enabled = true;
                rbSemanal.Enabled = true;
            }
            else
            {
                rbQuincenal.Enabled = false;
                rbSemanal.Enabled = false;
            }
        }

        private void frmNuevoTurno_Load(object sender, EventArgs e)
        {
            txtFecha_Validated(sender, e);
        }

        private void btnBuscarProf_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaProfesionales frm = new frmBuscaProfesionales();
                frm.ShowDialog();
                Profesionales u = frm.u;
                if (u != null)
                {
                    lblIdProf.Text = Convert.ToString(u.Idprofesionales);
                    txtProfesional.Text = u.Profesional;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaPacientes frm = new frmBuscaPacientes();
                frm.ShowDialog();
                Pacientes u = frm.u;
                if (u != null)
                {
                    lblIdPac.Text = Convert.ToString(u.Idpacientes);
                    txtPaciente.Text = u.Paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFecha_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtFecha.Text != "  /  /")
                {
                    DateTime a = Convert.ToDateTime(txtFecha.Text);
                    CultureInfo myCI = new CultureInfo("en-US");
                    CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                    DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
                    Calendar myCal = myCI.Calendar;
                    if (myCal.GetWeekOfYear(a, myCWR, myFirstDOW) % 2 == 0)
                    {
                        TSemana.Text = "2";
                    }
                    else
                    {
                        TSemana.Text = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
