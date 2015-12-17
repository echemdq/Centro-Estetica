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
    public partial class Consumo_Interno : Form
    {
        Productos oprod;
        BindingSource bin = new BindingSource();
        AccesoBD oacceso = new AccesoBD();
        string lala;
        DateTime fecha;
        public Consumo_Interno(string nro,DateTime fe)
        {
            InitializeComponent();
            fecha = fe;
            lala = nro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarproducto frm = new buscarproducto();
            frm.ShowDialog();
            oprod = frm.devolver();

            label3.Text = oprod.Id.ToString();
            textBox5.Text = oprod.Id.ToString();
            textBox2.Text = oprod.Descripcion;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {

                DataTable dt = new DataTable();
                string cmdtext = "select count(*) from movi where idmesa = '" + label1.Text + "' and idart = '" + label3.Text + "'";
                dt = oacceso.leerDatos(cmdtext);
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["count(*)"]) != 0)
                    {
                        string cmdtxt1 = "update movi set cantidad = cantidad + '" + textBox3.Text + "', total = 0 where idmesa = '" + label1.Text + "' and idart = '" + label3.Text + "'";
                        oacceso.ActualizarBD(cmdtxt1);
                        // cmdtxt1 = "update movi m  set total = total + '" + textBox3.Text + "' * '"+textBox4.Text+ "' where idmesa = '" + label1.Text + "' and idart = '" + textBox5.Text + "'";
                        // oacceso.ActualizarBD(cmdtxt1);
                    }
                    else
                    {
                        string cmdtext1 = "insert into movi(idart, idmesa, cantidad, total) values('" + label3.Text + "','" + label1.Text + "','" + textBox3.Text + "','0')";
                        oacceso.ActualizarBD(cmdtext1);
                    }
                }

                string cmdtxt = "select idart, descripcion, cantidad from movi inner join articulos on movi.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";

                dt = oacceso.leerDatos(cmdtxt);
                bin.DataSource = dt;
                dataGridView1.DataSource = bin;
                bin.ResetBindings(true);
                limpiar();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            textBox2.Clear();
            label3.Text = "";
            textBox3.Text = "1";

        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                limpiar();
                string cmdtext;
                if (Convert.ToInt32(textBox5.Text) < 1000000)
                {
                    cmdtext = "select idarticulos, stock, descripcion, precio, preciocalle from articulos where idarticulos = '" + textBox5.Text + "'";
                }
                else
                {
                    cmdtext = "select idarticulos, stock, descripcion, precio, preciocalle from articulos where codbarra = '" + textBox5.Text + "'";
                }
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                if (dt.Rows.Count.ToString() == "0")
                {
                    MessageBox.Show("Articulo inexistente");
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        label3.Text = Convert.ToString(dr["idarticulos"]);
                        textBox2.Text = Convert.ToString(dr["descripcion"]);


                        if (label3.Text != "")
                        {
                            textBox3.Focus();
                        }
                    }
                }
            }
        }

        private void Consumo_Interno_Load(object sender, EventArgs e)
        {
            label1.Text = lala;
            DataTable dt = new DataTable();
            string cmdtxt = "select idart, descripcion, cantidad from movi inner join articulos on movi.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";
            dt = oacceso.leerDatos(cmdtxt);
            bin.DataSource = dt;
            dataGridView1.DataSource = bin;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmdtext = "select count(*) as cant from movi where idmesa = '" + label1.Text + "'";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            int count = 0;
            foreach (DataRow dr in dt.Rows)
            {
                count = Convert.ToInt32(dr["cant"]);
            }
            if (count > 0)
            {
                

                    int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                    string lala = this.dataGridView1.Rows[filaseleccionada].Cells[0].Value + "";
                    cmdtext = "delete from movi where idart = '" + lala + "' and idmesa = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);
                    string cmdtxt = "select idart, descripcion, cantidad from movi inner join articulos on movi.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";

                    dt = oacceso.leerDatos(cmdtxt);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);         
            }
            else
            {
                MessageBox.Show("No hay articulos disponibles para eliminar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dRe = new DialogResult();            
            dRe = MessageBox.Show("Esta seguro de cerrar los consumos diarios?", "Cierre Consumo Interno", MessageBoxButtons.OKCancel);
            if (dRe == DialogResult.OK)
            {
                string cmdtext;
                DataTable dt = new DataTable();
                cmdtext = "select nro from contador";
                dt = oacceso.leerDatos(cmdtext);
                cmdtext = "update contador set nro = nro + 1";
                oacceso.ActualizarBD(cmdtext);
                int nro = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    nro = Convert.ToInt32(dr["nro"]) + 1;

                }
                string fecha1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string fecha2 = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                cmdtext = "insert into ventas(total, nrocomp, fecha, tipo) values('0','" + nro + "','" + fecha2 + "','1')";
                oacceso.ActualizarBD(cmdtext);
                int id = 0;
                cmdtext = "select max(idventas) from ventas";
                dt = oacceso.leerDatos(cmdtext);
                foreach (DataRow dr in dt.Rows)
                {
                    id = Convert.ToInt32(dr["max(idventas)"]);
                }
                cmdtext = "insert into movifinal(idart, idmesa, cantidad, total, idventas) select idart, idmesa, cantidad, total, '" + id + "' from movi where idmesa = '" + label1.Text + "'";
                oacceso.ActualizarBD(cmdtext);
                cmdtext = "delete from movi where idmesa = '" + label1.Text + "'";
                oacceso.ActualizarBD(cmdtext);
                cmdtext = "select idart, cantidad from movifinal where idventas = (select max(idventas) from movifinal)";
                dt = oacceso.leerDatos(cmdtext);
                foreach (DataRow dr in dt.Rows)
                {
                    cmdtext = "update articulos set stock = stock - '" + Convert.ToInt32(dr["cantidad"]) + "' where idarticulos = '" + Convert.ToInt32(dr["idart"]) + "'";
                    oacceso.ActualizarBD(cmdtext);
                }
            }
            this.Close();
        }
    }



}

