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
    public partial class RegistroTurnos : Form
    {
        public RegistroTurnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdtext = "insert into turnoseliminados (cliente, comentario) values ('" + textBox2.Text + "','" + textBox5.Text + "')";
                AccesoBD oacces = new AccesoBD();
                oacces.ActualizarBD(cmdtext);
                MessageBox.Show("Registro guardado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
