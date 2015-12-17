using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
namespace BullPadel
{
    public partial class MesasA : Form
    {        
        AccesoBD oacceso = new AccesoBD();
        static string nro;
        static string nombre12;
        static string caja;
        static DateTime fecha;
        bool mesa = false;
        public MesasA(string caca, DateTime fe)
        {
            caja = caca;
            fecha = fe;
            InitializeComponent();
            
        }
        private void manejador_de_evento_botones_generados(object sender, EventArgs e)
        {
            Button fuente = (Button)sender;
            nro = fuente.Name;
            nombre12 = fuente.Text;
            int d = nombre12.LastIndexOf(" ");
            string nombre13;
            if (d != -1)
            {
                nombre13 = nombre12.Substring(0, d);
                if (nombre13 == "PADEL")
                {
                    Turno frm = new Turno(nro, nombre12, nombre13, caja,fecha);
                    frm.Text = nombre12;
                    frm.Show();                    
                }
                else
                {
                    adicion1 frm = new adicion1(nro, nombre12, nombre13, "", "",fecha);
                    frm.Text = nombre12;
                    frm.Show();
                }
            }
            else
            {
                Acceso_Consumo_Interno frm = new Acceso_Consumo_Interno(nro, fecha);
                frm.Show();
            }
        }
        public string Devolver()
        {
            return nro;
        }
        private void MesasA_Load(object sender, EventArgs e)
        {
            string fech1 = fecha.ToString("dd-MM-yyyy");
            string fech2 = DateTime.Now.Date.ToString("dd-MM-yyyy");
            if (fech1 != fech2)
            {
                MessageBox.Show("Cuidado, la caja abierta corresponde al dia " + fech1);
            }
            label1.Text = "CAJA " + caja;
            string cmdtest = "select Cantidad, upper(Codigo) from configuraciones where cantidad is not null";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtest);
            int m = 1;
            int x = 1;
            int a = 1;
            foreach (DataRow dr in dt.Rows)
            {
                
                int cant = Convert.ToInt32(dr["Cantidad"]);
                for (int i = 1; i <= cant; i++)
                {
                    Button tmpButton = new Button();
                    string nombre = Convert.ToString(dr["upper(Codigo)"]) + " " + m;
                    string name = m.ToString();
                    tmpButton.Name = name;
                    tmpButton.Text = nombre;
                    tmpButton.Font = new Font("Verdana", 8, FontStyle.Bold);
                    tmpButton.Size = new Size(85, 23);
                    tmpButton.BackColor = Color.GreenYellow;
                    if (x == 1)
                    {
                        
                        tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                        pnlContainer.Controls.Add(tmpButton);
                    }
                    else if (x > 1 && Convert.ToString(dr["upper(Codigo)"]) == "PADEL")
                    {
                        //nro = tmpButton.Name;
                        
                        nombre = Convert.ToString(dr["upper(Codigo)"]) + " " + a;                        
                        tmpButton.Text = nombre;                        
                        tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                        flowLayoutPanel1.Controls.Add(tmpButton);
                        a++;
                    }
                    m++;
                }
                x++;
          }
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToString(dr["upper(Codigo)"]) == "CALLE")
                {
                    Button tmpButton = new Button();
                    string nombre = Convert.ToString(dr["upper(Codigo)"]) + " " + "1";
                    string name = m.ToString();
                    tmpButton.Name = name;
                    tmpButton.Text = nombre;
                    tmpButton.Font = new Font("Verdana", 8, FontStyle.Bold);
                    tmpButton.Size = new Size(85, 23);
                    tmpButton.BackColor = Color.GreenYellow;
                    tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                    flowLayoutPanel3.Controls.Add(tmpButton);
                    
                }
                else if (Convert.ToString(dr["upper(Codigo)"]) == "CONSUMO")
                {
                    m++;
                    Button tmpButton = new Button();
                    string nombre = Convert.ToString(dr["upper(Codigo)"]);
                    string name = m.ToString();
                    tmpButton.Name = name;
                    tmpButton.Text = nombre;
                    tmpButton.Font = new Font("Verdana", 8, FontStyle.Bold);
                    tmpButton.Size = new Size(85, 23);
                    tmpButton.BackColor = Color.GreenYellow;
                    tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                    flowLayoutPanel2.Controls.Add(tmpButton);
                }
            }

        }

        private void MesasA_Activated(object sender, EventArgs e)
        {
            mesa = false;  
            string cmdtext = "select idmesa from movi group by idmesa";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (Control c in pnlContainer.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.GreenYellow;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if(c.Name == Convert.ToString(dr["idmesa"]))
                        {
                            c.BackColor = Color.Red;
                            mesa = true;
                            break;
                        }

                    }
                }
            }
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.GreenYellow;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (c.Name == Convert.ToString(dr["idmesa"]))
                        {
                            c.BackColor = Color.Red;
                            mesa = true;
                            break;
                        }

                    }
                }
            }
            cmdtext = "select idcancha from movipadel group by idcancha";
            dt = oacceso.leerDatos(cmdtext);
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.GreenYellow;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (c.Name == Convert.ToString(dr["idcancha"]))
                        {
                            c.BackColor = Color.Red;
                            mesa = true;
                            break;
                        }
                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mesa)
            {
                DialogResult dRe = new DialogResult();
                dRe = MessageBox.Show("Esta seguro de cerrar la caja", "Cierre Caja", MessageBoxButtons.OKCancel);
                if (dRe == DialogResult.OK)
                {
                    dRe = MessageBox.Show("ESTA MUY SEGURO DE CERRAR LA CAJA ?????", "Cierre Caja", MessageBoxButtons.OKCancel);
                    if (dRe == DialogResult.OK)
                    {
                        string cmdtext = "update cajas set id_fin = (select max(idventas) from ventas) where id_fin = 0";
                        oacceso.ActualizarBD(cmdtext);
                        this.Close();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Hay mesas abiertas");
            }
        }




    }
}
