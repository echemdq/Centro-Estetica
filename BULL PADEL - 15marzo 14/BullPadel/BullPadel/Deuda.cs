using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BullPadel
{
    public partial class Deuda : Form
    {
        AccesoBD oacceso = new AccesoBD();
        string id;
        public Deuda(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal deuda = Convert.ToDecimal(textBox2.Text);
                string cmdtext = "update turnos set deuda = deuda + " + deuda + " where idturnos = '" + id + "'";
                oacceso.ActualizarBD(cmdtext);
                MessageBox.Show("Deuda cargada exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void Deuda_Load(object sender, EventArgs e)
        {

        }
    }
}
