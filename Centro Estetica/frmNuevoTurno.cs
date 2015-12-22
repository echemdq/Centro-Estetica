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
    public partial class frmNuevoTurno : Form
    {
        public frmNuevoTurno(string fecha, string hora)
        {
            InitializeComponent();
            txtFecha.Text = fecha;
            txtHora.Text = hora;
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
    }
}
