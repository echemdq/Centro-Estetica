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
    public partial class Gastos : Form
    {
        AccesoBD oacceso = new AccesoBD();
        BindingSource bin = new BindingSource();
        static string caja;
        DateTime fecha;
        public Gastos(string lala,DateTime fe)
        {
            caja = lala;
            fecha = fe;
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            comboBox1.Text = caja;
            comboBox1.Enabled = false;
            //maskedTextBox1.Text = DateTime.Today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Caja");
            }
            else
            {
                //DateTime desde = Convert.ToDateTime(maskedTextBox1.Text);
                //string d = desde.ToString("yyyy-MM-dd HH:mm:ss");
                string fecha2 = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                string cmdtext = "insert into gastos(caja, importe, detalle, fecha) values('" + comboBox1.SelectedItem + "','" + textBox2.Text + "','" + textBox1.Text + "','" + fecha2 + "')";
                oacceso.ActualizarBD(cmdtext);
                MessageBox.Show("Gasto Guardado Correctamente");
                this.Close();
            }            
        }
    }
}
