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
    public partial class Articulos_Consumidos : Form
    {
        Productos aux;
        AccesoBD oacceso = new AccesoBD();
        BindingSource bin = new BindingSource();
        public Articulos_Consumidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (maskedTextBox1.Text == "  /  /" || maskedTextBox2.Text == "  /  /")
            {
                MessageBox.Show("Ingrese fechas validas");
            }
            else
            {
                string cod = textBox3.Text;
                DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                h = h.AddDays(1);
                string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                if (cod == "")
                {
                    string cmdtext = "call bullpadelbd.consumoprod('" + 0 + "','" + desde + "','" + hasta + "')";
                    dt = oacceso.leerDatos(cmdtext);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);
                }
                else
                {
                    string cmdtext = "call bullpadelbd.consumoprod('" + cod + "','" + desde + "','" + hasta + "')";
                    dt = oacceso.leerDatos(cmdtext);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarproducto FRM = new buscarproducto();
            FRM.ShowDialog();
            aux = FRM.devolver();
            if (aux != null)
            {
                textBox3.Text = aux.Id.ToString();
            }
        }

        private void Articulos_Consumidos_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.Date.ToShortDateString();
            maskedTextBox2.Text = DateTime.Now.Date.ToShortDateString();
        }
    }
}
