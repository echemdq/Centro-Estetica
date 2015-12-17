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
    public partial class Apertura_Caja : Form
    {
        AccesoBD oacceso = new AccesoBD();
        string fecha;
        int caja;
        int idini;
        public Apertura_Caja(string f, int c, int i)
        {
            InitializeComponent();
            fecha = f;
            caja = c;
            idini = i;
        }

        private void Apertura_Caja_Load(object sender, EventArgs e)
        {
            label1.Text = "Caja: " + caja;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdtext = "insert into cajas(caja, fecha, id_ini, id_fin, inicio) values('"+caja+"','" + fecha + "','" + idini + "','0', '"+textBox1.Text+"')";
            oacceso.ActualizarBD(cmdtext);
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }
}
