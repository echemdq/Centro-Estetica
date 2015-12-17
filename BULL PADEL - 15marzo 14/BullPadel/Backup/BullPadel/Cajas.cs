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
    public partial class Cajas : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public Cajas()
        {
            InitializeComponent();
        }

        private void Cajas_Load(object sender, EventArgs e)
        {
            DateTime h = DateTime.Today;
            string fecha = h.ToString("yyyy-MM-dd HH:mm:ss");
            string cmdtext = "select caja from cajas where fecha = '"+fecha+"'";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            int caja = 0;
            foreach (DataRow dr in dt.Rows)
            {
                caja = Convert.ToInt32(dr["caja"]);
                if (caja == 1)
                {
                    button1.Text = "CAJA 1" + "\r" + "Caja ya abierta en el dia de la fecha";
                    button1.Enabled = false;
                    button1.BackColor = Color.Orange;
                }
                else if (caja == 2)
                {
                    button2.Text = "CAJA 2" + "\r" + "Caja ya abierta en el dia de la fecha";
                    button2.Enabled = false;
                    button2.BackColor = Color.Orange;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cmdtext = "select max(idventas) as id from ventas";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            int idini = 0;
            DateTime h = DateTime.Today;
            string fecha = h.ToString("yyyy-MM-dd HH:mm:ss");
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToString(dr["id"]) == "")
                {
                    break;
                }
                else
                {
                    idini = Convert.ToInt32(dr["id"]) + 1;
                    break;
                }            
            }
            if (idini == 0)
            {
                idini = 1;
            }
            cmdtext = "insert into cajas(caja, fecha, id_ini, id_fin) values('1','"+fecha+"','"+idini+"','0')";
            oacceso.ActualizarBD(cmdtext);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdtext = "select max(idventas) as id from ventas";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            int idini = 0;
            DateTime h = DateTime.Today;
            string fecha = h.ToString("yyyy-MM-dd HH:mm:ss");
            foreach (DataRow dr in dt.Rows)
            {
                idini = Convert.ToInt32(dr["id"]) + 1;
            }
            cmdtext = "insert into cajas(caja, fecha, id_ini, id_fin) values('2','" + fecha + "','" + idini + "','0')";
            oacceso.ActualizarBD(cmdtext);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdtext = "update cajaestado set estado = '0'";
            oacceso.ActualizarBD(cmdtext);
        }
    }
}
