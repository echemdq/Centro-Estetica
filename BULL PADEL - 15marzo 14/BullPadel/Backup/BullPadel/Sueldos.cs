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
    public partial class Sueldos : Form
    {
        AccesoBD oacceso = new AccesoBD();
        static string caja;
        DateTime fecha;
        public Sueldos(string lala,DateTime fe)
        {
            caja = lala;
            InitializeComponent();
            fecha = fe;
        }

        private void Sueldos_Load(object sender, EventArgs e)
        {
            //maskedTextBox1.Text = DateTime.Today.ToShortDateString();
            string cmdtext = "select upper(empleado) from empleados";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(Convert.ToString(dr["upper(empleado)"]));
            }
            comboBox2.Text = caja;
            comboBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
            //string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
            string fecha2 = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string cmdtext = "insert into sueldo(idempleados, importe, fecha, descripcion, caja)values ((select idempleados from empleados where empleado = '"+comboBox1.SelectedItem+"'), '"+Convert.ToDecimal(textBox2.Text)+"','"+fecha2+"', '"+textBox3.Text +"','" +comboBox2.SelectedItem+"')";
            oacceso.ActualizarBD(cmdtext);
            MessageBox.Show("Movimiento Guardado Correctamente");
            this.Close();
        }
    }
}
