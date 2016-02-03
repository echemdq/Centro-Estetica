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
    public partial class frmHistorialCliente : Form
    {
        Pacientes pac = null;
        public frmHistorialCliente()
        {
            InitializeComponent();
        }

        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
            frmBuscaPacientes frm = new frmBuscaPacientes();
            frm.ShowDialog();
            pac = frm.u;
            if (pac != null)
            {
                txtPaciente.Text = pac.Paciente;
            }
            else
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaPacientes frm = new frmBuscaPacientes();
            frm.ShowDialog();
            pac = frm.u;
            if (pac != null)
            {
                txtPaciente.Text = pac.Paciente;
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (pac != null)
                {
                    if (rbAsistidos.Checked)
                    {

                    }
                    else
                    {

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
