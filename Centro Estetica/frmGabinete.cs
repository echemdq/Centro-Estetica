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
    public partial class frmGabinete : Form
    {
        int idprof = 0;
        Acceso_BD oacceso = new Acceso_BD();
        public frmGabinete(int id, string prof)
        {
            InitializeComponent();
            idprof = id;
            txtProfesional.Text = prof;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGabinete.Text != "")
                {
                    oacceso.ActualizarBD("update profesionales set gabinete = '" + txtGabinete.Text + "' where idprofesionales = '" + idprof + "'");
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
