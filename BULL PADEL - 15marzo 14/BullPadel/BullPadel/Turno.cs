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
    public partial class Turno : Form
    {
        string lala;
        string nombre12;
        string nombre13;
        string lolo;
        string jugnom;
        AccesoBD oacceso = new AccesoBD();
        string caja;
        DateTime fecha;
        public Turno(string nro, string nombre, string nombre1, string caaja, DateTime fe)
        {
            lala = nro;
            nombre12 = nombre;
            nombre13 = nombre1;
            caja = caaja;
            fecha = fe;
            InitializeComponent();
        }

        private void Turno_Load(object sender, EventArgs e)
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(button1, "Cerrar Cancha");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lolo = lala + "1";
            if (j1.BackColor == Color.GreenYellow)
            {
                Jugador frm1 = new Jugador();
                frm1.ShowDialog();
                jugnom = frm1.devolver();
                if (jugnom != "" && jugnom != null)
                {
                    adicion1 frm = new adicion1(lolo, jugnom.ToUpper(), nombre13, "j1", jugnom.ToUpper(), fecha);
                    frm.ShowDialog();
                }
                else
                {
                    adicion1 frm = new adicion1(lolo, j1.Text.ToUpper(), nombre13, "j1", "Jugador 1",fecha);
                    frm.ShowDialog();
                }
            }
            else
            {
                adicion1 frm = new adicion1(lolo, j1.Text.ToUpper(), nombre13, "j1", j1.Text.ToUpper(),fecha);
                frm.ShowDialog();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lolo = lala + "2";
            if (j2.BackColor == Color.GreenYellow)
            {
                Jugador frm1 = new Jugador();
                frm1.ShowDialog();
                jugnom = frm1.devolver();
                if (jugnom != "" && jugnom != null)
                {
                    adicion1 frm = new adicion1(lolo, jugnom.ToUpper(), nombre13, "j2", jugnom.ToUpper(),fecha);
                    frm.ShowDialog();
                }
                else
                {
                    adicion1 frm = new adicion1(lolo, j2.Text.ToUpper(), nombre13, "j2", "Jugador 2",fecha);
                    frm.ShowDialog();
                }
            }
            else
            {
                adicion1 frm = new adicion1(lolo, j2.Text.ToUpper(), nombre13, "j2", j2.Text.ToUpper(),fecha);
                frm.ShowDialog();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lolo = lala + "3";
            if (j3.BackColor == Color.GreenYellow)
            {
                Jugador frm1 = new Jugador();
                frm1.ShowDialog();
                jugnom = frm1.devolver();
                if (jugnom != "" && jugnom != null)
                {
                    adicion1 frm = new adicion1(lolo, jugnom.ToUpper(), nombre13, "j3", jugnom.ToUpper(),fecha);
                    frm.ShowDialog();
                }
                else
                {
                    adicion1 frm = new adicion1(lolo, j3.Text.ToUpper(), nombre13, "j3", "Jugador 3",fecha);
                    frm.ShowDialog();
                }
            }
            else
            {
                adicion1 frm = new adicion1(lolo, j3.Text.ToUpper(), nombre13, "j3", j3.Text.ToUpper(),fecha);
                frm.ShowDialog();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lolo = lala + "4";
            if (j4.BackColor == Color.GreenYellow)
            {
                Jugador frm1 = new Jugador();
                frm1.ShowDialog();
                jugnom = frm1.devolver();
                if (jugnom != "" && jugnom != null)
                {
                    adicion1 frm = new adicion1(lolo, jugnom.ToUpper(), nombre13, "j4", jugnom.ToUpper(),fecha);
                    frm.ShowDialog();
                }
                else
                {
                    adicion1 frm = new adicion1(lolo, j4.Text.ToUpper(), nombre13, "j4", "Jugador 4",fecha);
                    frm.ShowDialog();
                }
            }
            else
            {
                adicion1 frm = new adicion1(lolo, j4.Text.ToUpper(), nombre13, "j4", j4.Text.ToUpper(),fecha);
                frm.ShowDialog();
            }            
        }

        private void Turno_Activated(object sender, EventArgs e)
        {
            string cmdtext = "select idjugador, nombre, estado, sum(total) as total from movipadel where idcancha = '"+lala+"' group by idjugador, nombre, estado";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.GreenYellow;
                    c.Text = "Jugador " + c.Name.Substring(1, 1);
                    button1.Text = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (c.Name == Convert.ToString(dr["idjugador"]) && Convert.ToString(dr["estado"]) == "0")
                        {
                            c.BackColor = Color.Red;
                            c.Text = Convert.ToString(dr["nombre"]) + "\r" + "Consumidos: $" + Convert.ToString(dr["total"]);
                            break;
                        }
                        else if (c.Name == Convert.ToString(dr["idjugador"]) && Convert.ToString(dr["estado"]) == "1")
                        {
                            c.BackColor = Color.Orange;
                            c.Text = Convert.ToString(dr["nombre"]) + "\r" + "Abonados: $" + Convert.ToString(dr["total"]);
                            c.Enabled = false;
                            break;
                        }

                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool ok = true;
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.BackColor == Color.GreenYellow || c.BackColor == Color.Orange)
                    {
                        ok = true;                     
                    }
                    else
                    {
                        ok = false;
                        break;
                    }
                }
            }
            if (ok == true)
            {
                string cmdtext;
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Esta seguro de cerrar la cancha de padel", "Cierre Cancha", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    cmdtext = "select nro from contador";
                    DataTable dt = new DataTable();
                    dt = oacceso.leerDatos(cmdtext);
                    cmdtext = "update contador set nro = nro + 1";
                    oacceso.ActualizarBD(cmdtext);
                    int nro = 0;
                    foreach (DataRow drt in dt.Rows)
                    {
                        nro = Convert.ToInt32(drt["nro"]) + 1;
                    }
                    string fecha1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmdtext = "select sum(total) as total from movipadel where idcancha = '" + lala + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    string vta = "0";
                    foreach (DataRow drt in dt.Rows)
                    {
                        vta = Convert.ToString(drt["total"]);
                    }
                    string fecha2 = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                    cmdtext = "insert into ventas(total, nrocomp, fecha, idcajas) values('" + vta.Replace(",", ".") + "','" + nro + "','" + fecha2 + "','"+caja+"')";
                    oacceso.ActualizarBD(cmdtext);
                    int id = 0;
                    cmdtext = "select max(idventas) from ventas";
                    dt = oacceso.leerDatos(cmdtext);
                    foreach (DataRow drt in dt.Rows)
                    {
                        id = Convert.ToInt32(drt["max(idventas)"]);
                    }

                    cmdtext = "insert into movifinal(idart, idmesa, cantidad, nombre, total, idventas) select idart, idcancha, cantidad, nombre, total, '" + id + "' from movipadel where idcancha = '" + lala + "'";
                    oacceso.ActualizarBD(cmdtext);
                    cmdtext = "delete from movipadel where idcancha = '" + lala + "'";
                    oacceso.ActualizarBD(cmdtext);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun queda un Jugador sin Pagar");
            }
            
                
            
            
        }
    }
}
