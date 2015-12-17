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
            string cmdtext = "select caja, id_fin from cajas where fecha = '"+fecha+"' or id_fin = 0";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            int caja = 0;
            int id;
            foreach (DataRow dr in dt.Rows)
            {
                caja = Convert.ToInt32(dr["caja"]);
                id = Convert.ToInt32(dr["id_fin"]);
                if (caja == 1)
                {
                    button1.Text = "CAJA 1" + "\r" + "Caja ya abierta en el dia o anteriormente";
                    button1.Enabled = false;
                    button1.BackColor = Color.Orange;
                    if (id == 0)
                    {
                        button2.Enabled = false;
                    }
                }
                else if (caja == 2)
                {
                    button2.Text = "CAJA 2" + "\r" + "Caja ya abierta en el dia o anteriormente";
                    button2.Enabled = false;
                    button2.BackColor = Color.Orange;
                    if (id == 0)
                    {
                        button1.Enabled = false;
                    }
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
            Apertura_Caja frm = new Apertura_Caja(fecha, 1, idini);
            frm.ShowDialog();
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
            Apertura_Caja frm = new Apertura_Caja(fecha, 2, idini);
            frm.ShowDialog();
            this.Close();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdtext = "update cajaestado set estado = '0'";
            oacceso.ActualizarBD(cmdtext);
        }
    }
}
