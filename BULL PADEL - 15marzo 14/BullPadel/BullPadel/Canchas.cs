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
    public partial class Canchas : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public Canchas()
        {
            InitializeComponent();
        }

        
        private void Canchas_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.Date.ToShortDateString();
            maskedTextBox2.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "  /  /" || maskedTextBox2.Text == "  /  /")
            {
                MessageBox.Show("Ingrese fechas validas");
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                    string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                    //h = h.AddDays(1);
                    string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                    string cmdtext = "select v.total from bullpadelbd.ventas v inner join bullpadelbd.movifinal m on v.idventas = m.idventas where m.nombre is not null and v.fecha between '" + desde + "' and '" + hasta + "' group by v.nrocomp";
                    // string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "'";
                    DataTable dt = new DataTable();
                    dt = oacceso.leerDatos(cmdtext);
                    decimal ventas = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        ventas = ventas + Convert.ToDecimal(dr["total"]);

                    }
                    textBox3.Text = ventas.ToString();
                }
                else
                {
                    if (Convert.ToString(comboBox1.SelectedItem) == "1")
                    {
                        DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                        string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                        // h = h.AddDays(1);
                        string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                        string cmdtext = "select v.total from bullpadelbd.ventas v inner join bullpadelbd.movifinal m on v.idventas = m.idventas where m.nombre is not null and v.fecha between '" + desde + "' and '" + hasta + "' and idcajas = '1' group by v.nrocomp";
                        //string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "' and idcajas = '1'";
                        DataTable dt = new DataTable();
                        dt = oacceso.leerDatos(cmdtext);
                        decimal ventas = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            ventas = ventas + Convert.ToDecimal(dr["total"]);
                        }
                        textBox3.Text = ventas.ToString();
                    }
                    else
                    {
                        DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                        string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                        //h = h.AddDays(1);
                        string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                        string cmdtext = "select v.total from bullpadelbd.ventas v inner join bullpadelbd.movifinal m on v.idventas = m.idventas where m.nombre is not null and v.fecha between '" + desde + "' and '" + hasta + "' and idcajas = '2' group by v.nrocomp";
                        //string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "' and idcajas = '2'";
                        DataTable dt = new DataTable();
                        dt = oacceso.leerDatos(cmdtext);
                        decimal ventas = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            ventas = ventas + Convert.ToDecimal(dr["total"]);

                        }
                        textBox3.Text = ventas.ToString();
                    }                    
                }
            }
        }        
    }
}