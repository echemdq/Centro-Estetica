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
    public partial class Cambio_Precio : Form
    {
        Decimal precio = 0;
        AccesoBD oacceso = new AccesoBD();
        public Cambio_Precio()
        {
            InitializeComponent();
        }
        public decimal devolver()
        {
            return precio;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdtext = "select 'ok' as 'clave' from configuraciones where codigo = 'clave' and clave = '" + textBox1.Text + "'";
            DataTable dt = oacceso.leerDatos(cmdtext);
            string ok = "";
            foreach (DataRow dr in dt.Rows)
            {
                ok = Convert.ToString(dr["clave"]);
            }
            if (ok == "ok")
            {
                precio = Convert.ToDecimal(textBox2.Text.Replace(".",","));
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void Cambio_Precio_Load(object sender, EventArgs e)
        {

        }
    }
}
