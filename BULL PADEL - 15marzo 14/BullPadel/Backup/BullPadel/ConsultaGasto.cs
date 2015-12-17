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
    public partial class ConsultaGasto : Form
    {
        BindingSource bin = new BindingSource();
        AccesoBD oacceso = new AccesoBD();
        public ConsultaGasto()
        {
            InitializeComponent();
        }

        private void ConsultaGasto_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.Date.ToShortDateString();
            maskedTextBox2.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "  /  /" || maskedTextBox2.Text == "  /  /")
            {
                MessageBox.Show("Ingrese fechas validas");
            }
            else
            {
                DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                h = h.AddDays(1);
                string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                string cmdtext = "select detalle, importe, caja from gastos where fecha between '" + desde + "' and '" + hasta + "'";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                bin.DataSource = dt;
                dataGridView1.DataSource = bin;
                bin.ResetBindings(true);
                decimal total = 0;
                foreach(DataRow dr in dt.Rows)
                {
                    total = total + Convert.ToDecimal(dr["importe"]);
                }                
                textBox1.Text = total.ToString();
            }
        }
    }
}
