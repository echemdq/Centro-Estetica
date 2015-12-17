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
    public partial class Configuracion_Turnero : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public Configuracion_Turnero()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string horaini = maskedTextBox1.Text + ":00";
            string horafin = maskedTextBox2.Text + ":00";
            oacceso.ActualizarBD("update configuraciones set hora = '" + horaini + "' where codigo = 'horaini'");
            oacceso.ActualizarBD("update configuraciones set hora = '" + horafin + "' where codigo = 'horafin'");
            MessageBox.Show("Configuracion cargada correctamente");
            this.Close(); 
        }


    }
}
