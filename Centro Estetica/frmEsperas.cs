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
    public partial class frmEsperas : Form
    {
        ControladoraEsperas controle = new ControladoraEsperas();
        public frmEsperas()
        {
            InitializeComponent();
        }

        private void frmEsperas_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaPacientes frm = new frmBuscaPacientes();
                frm.ShowDialog();
                Pacientes u = frm.u;
                if (u != null)
                {
                    txtPaciente.Text = u.Paciente;
                    txtTelefono.Text = u.Telefono + " " + u.Celular;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Esperas es = new Esperas(0, txtPaciente.Text, txtTelefono.Text, txtComentarios.Text, DateTime.Now);
                controle.Agregar(es);
                MessageBox.Show("Espera cargada exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
