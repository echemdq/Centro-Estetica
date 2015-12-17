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
    public partial class Consulta_Cajas : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public Consulta_Cajas()
        {
            InitializeComponent();
        }

        private void Consulta_Cajas_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
            string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
            string cajachica = "0";
            int idcaja = 0;
            decimal ingreso = 0;
            decimal egreso = 0;
            DataTable dt = oacceso.leerDatos("select idcajas, inicio from cajas where caja = '"+comboBox1.Text+"' and fecha = '"+desde+"'");
            foreach (DataRow dr in dt.Rows)
            {
                idcaja = Convert.ToInt32(dr["idcajas"]);
                cajachica = Convert.ToString(dr["inicio"]);
            }
            dt = oacceso.leerDatos("select tipo, importe from movimientoscaja where idcaja = '" + idcaja + "'");
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToString(dr["tipo"]) == "1")
                {
                    ingreso += Convert.ToDecimal(dr["importe"]);
                }
                else
                {
                    egreso += Convert.ToDecimal(dr["importe"]);
                }
            }
            cajatxt.Text = cajachica;
            ingresotxt.Text = ingreso.ToString();
            egresotxt.Text = egreso.ToString();
        }
    }
}
