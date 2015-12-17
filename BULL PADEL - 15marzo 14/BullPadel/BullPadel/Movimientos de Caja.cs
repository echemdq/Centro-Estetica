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
    public partial class Movimientos_de_Caja : Form
    {
        AccesoBD oacceso = new AccesoBD(); 
        public Movimientos_de_Caja()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            int idcaja = 0;
            string importe = textBox2.Text;
            string concepto = textBox1.Text;
            int tipo = 0;
            if (comboBox1.Text == "Ingreso")
            {
                tipo = 1;
            }
            else if (comboBox1.Text == "Egreso")
            {
                tipo = 2;
            }
            DataTable dt = oacceso.leerDatos("select idcajas from cajas where id_fin = '0'");
            foreach (DataRow dr in dt.Rows)
            {
                idcaja = Convert.ToInt32(dr["idcajas"]);
            }
            if (idcaja == 0)
            {
                MessageBox.Show("Para realizar un movimiento debe haber una caja abierta");
            }
            else
            {
                if (tipo == 0)
                {
                    MessageBox.Show("Para realizar un movimiento debe seleccionar el tipo de movimiento");
                }
                else
                {
                    oacceso.ActualizarBD("insert into movimientoscaja(idcaja, concepto, tipo, importe) values('"+idcaja+"','"+concepto+"','"+tipo+"','"+importe+"')");
                }
            }
        }

        private void Movimientos_de_Caja_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            
        }
    }
}
