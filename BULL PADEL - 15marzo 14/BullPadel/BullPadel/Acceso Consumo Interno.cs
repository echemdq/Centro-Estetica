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
    public partial class Acceso_Consumo_Interno : Form
    {
        AccesoBD oacceso = new AccesoBD();
        string nro;
        DateTime fecha;
        public Acceso_Consumo_Interno(string n, DateTime t)
        {
            InitializeComponent();
            nro = n;
            fecha = t;
        }

        private void Acceso_Consumo_Interno_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
            string cmdtext = "select upper(empleado) from empleados";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(Convert.ToString(dr["upper(empleado)"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = oacceso.leerDatos("select idempleados from empleados where empleado = '" + comboBox1.Text + "' and contrasena = '" + textBox1.Text + "'");
            int x = 0;
            foreach(DataRow dr in dt.Rows)
            {
                string i = Convert.ToString(dr["idempleados"]);
                
                    Consumo_Interno frm = new Consumo_Interno(nro, fecha, Convert.ToInt32(i));
                    frm.Show();
                    this.Close();
                    x = 1;
            }
            if (x == 0)
            {
                MessageBox.Show("La contraseña no coincide con el empleado");
            }
        }
    }
}
