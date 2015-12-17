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
    public partial class adicion1 : Form
    {
        AccesoBD oacceso = new AccesoBD();
        string lala;
        string nombre12;
        bool entro = false;
        string nombre13;
        string idj;
        string njug;
        Productos oprod;
        BindingSource bin = new BindingSource();
        decimal VTATOTAL = 0;
        DateTime fecha;
        public adicion1(string nro, string nombre, string nombre1, string idjugador, string njugador,DateTime fe)
        {
            fecha = fe;
            lala = nro;
            nombre12 = nombre;
            nombre13 = nombre1;
            idj = idjugador;
            njug = njugador;
            InitializeComponent();
        }

        private void adicion1_Load(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(button1, "Agregar Articulo Adicion");
            tp.SetToolTip(button4, "Borrar Articulo Adicion");
            tp.SetToolTip(button3, "Cerrar Mesa");
            label1.Text = lala;
            label8.Text = nombre12;
            DataTable dt = new DataTable();
            if (nombre13 != "PADEL")
            {
                string cmdtxt = "select idart, descripcion, cantidad, precio, total from movi inner join articulos on movi.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";
                dt = oacceso.leerDatos(cmdtxt);
                bin.DataSource = dt;
                dataGridView1.DataSource = bin;
                string cmdt = "select sum(total) from movi where idmesa ='" + label1.Text + "'";
                dt = oacceso.leerDatos(cmdt);
                foreach (DataRow dr in dt.Rows)
                {
                    label7.Text = "Total: $" + Convert.ToString(dr["sum(total)"]);
                    string vtatotal = Convert.ToString(dr["sum(total)"]);
                    if (vtatotal != "")
                    {
                        VTATOTAL = Convert.ToDecimal(vtatotal);
                    }

                }
            }
            else
            {
                string cmdtxt = "select idart, descripcion, cantidad, precio, total from movipadel m inner join articulos on m.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";
                dt = oacceso.leerDatos(cmdtxt);
                bin.DataSource = dt;
                dataGridView1.DataSource = bin;
                string cmdt = "select sum(total) from movipadel where idmesa ='" + label1.Text + "'";
                dt = oacceso.leerDatos(cmdt);
                foreach (DataRow dr in dt.Rows)
                {
                    label7.Text = "Total: $" + Convert.ToString(dr["sum(total)"]);
                    string vtatotal = Convert.ToString(dr["sum(total)"]);
                    if (vtatotal != "")
                    {
                        VTATOTAL = Convert.ToDecimal(vtatotal);
                    }

                }
            }
            //bin.ResetBindings(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarproducto frm = new buscarproducto();
            frm.ShowDialog();
            oprod = frm.devolver();
            if (oprod != null && nombre12 != "CALLE 1")
            {
                label3.Text = oprod.Id.ToString();
                textBox5.Text = oprod.Id.ToString();
                textBox2.Text = oprod.Descripcion;
                textBox4.Text = oprod.Precio.ToString();
            }
            else if(oprod != null && nombre12 == "CALLE 1")
            {
                label3.Text = oprod.Id.ToString();
                textBox5.Text = oprod.Id.ToString();
                
                textBox2.Text = oprod.Descripcion;
                decimal preciocalle = Convert.ToDecimal(oprod.Preciocalle.Replace(",","."));
                if (preciocalle == 0)
                {
                    MessageBox.Show("El producto elegido no posee Precio Mostrador, se vendera al Precio Confiteria");
                    textBox4.Text = oprod.Precio.ToString();
                    
                }
                else
                {
                    textBox4.Text = oprod.Preciocalle.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                if (nombre13 != "PADEL")
                {
                    decimal total = Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox4.Text);
                    string total1 = total.ToString();
                    total1 = total1.Replace(",", ".");
                    DataTable dt = new DataTable();
                    string cmdtext = "select count(*) from movi where idmesa = '" + label1.Text + "' and idart = '" + label3.Text + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (Convert.ToInt32(dr["count(*)"]) != 0)
                        {
                            string cmdtxt1 = "update movi set cantidad = cantidad + '" + textBox3.Text + "', total = total + '" + textBox3.Text + "' * '" + textBox4.Text.Replace(",", ".") + "' where idmesa = '" + label1.Text + "' and idart = '" + label3.Text + "'";
                            oacceso.ActualizarBD(cmdtxt1);
                            // cmdtxt1 = "update movi m  set total = total + '" + textBox3.Text + "' * '"+textBox4.Text+ "' where idmesa = '" + label1.Text + "' and idart = '" + textBox5.Text + "'";
                            // oacceso.ActualizarBD(cmdtxt1);
                        }
                        else
                        {
                            string cmdtext1 = "insert into movi(idart, idmesa, cantidad, total) values('" + label3.Text + "','" + label1.Text + "','" + textBox3.Text + "','" + total1 + "')";
                            oacceso.ActualizarBD(cmdtext1);
                        }
                    }

                    string cmdtxt = "select idart, descripcion, cantidad, precio, total from movi inner join articulos on movi.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";

                    dt = oacceso.leerDatos(cmdtxt);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);
                    string cmdt = "select sum(total) from movi where idmesa ='" + label1.Text + "'";
                    dt = oacceso.leerDatos(cmdt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        label7.Text = "Total: $" + Convert.ToString(dr["sum(total)"]);
                        string vtatotal = Convert.ToString(dr["sum(total)"]);
                        VTATOTAL = Convert.ToDecimal(vtatotal);
                    }
                    limpiar();
                }
                else
                {
                    decimal total = Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox4.Text);
                    string total1 = total.ToString();
                    total1 = total1.Replace(",", ".");
                    DataTable dt = new DataTable();
                    string cmdtext = "select count(*) from movipadel where idmesa = '" + label1.Text + "' and idart = '" + textBox5.Text + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (Convert.ToInt32(dr["count(*)"]) != 0)
                        {
                            string cmdtxt1 = "update movipadel set cantidad = cantidad + '" + textBox3.Text + "', total = total + '" + textBox3.Text + "' * '" + textBox4.Text.Replace(",", ".") + "' where idmesa = '" + label1.Text + "' and idart = '" + textBox5.Text + "'";
                            oacceso.ActualizarBD(cmdtxt1);
                            // cmdtxt1 = "update movi m  set total = total + '" + textBox3.Text + "' * '"+textBox4.Text+ "' where idmesa = '" + label1.Text + "' and idart = '" + textBox5.Text + "'";
                            // oacceso.ActualizarBD(cmdtxt1);
                        }
                        else
                        {
                            int i = lala.Length;
                            string lele = lala.Substring(0, i - 1);
                            int q = njug.LastIndexOf("\r");
                            if (q < 0)
                            {
                                q = njug.Length;
                            }
                            string cmdtext1 = "insert into movipadel(idart, idmesa, cantidad, total, idcancha, idjugador, nombre, estado) values('" + textBox5.Text + "','" + label1.Text + "','" + textBox3.Text + "','" + total1 + "','" + lele +"','" + idj + "','" + njug.Substring(0, q) + "','0')";
                            oacceso.ActualizarBD(cmdtext1);
                        }
                    }

                    string cmdtxt = "select idart, descripcion, cantidad, precio, total from movipadel m inner join articulos on m.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";

                    dt = oacceso.leerDatos(cmdtxt);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);
                    string cmdt = "select sum(total) from movipadel where idmesa ='" + label1.Text + "'";
                    dt = oacceso.leerDatos(cmdt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        label7.Text = "Total: $" + Convert.ToString(dr["sum(total)"]);
                        string vtatotal = Convert.ToString(dr["sum(total)"]);
                        VTATOTAL = Convert.ToDecimal(vtatotal);
                    }
                    limpiar();
                }
            }
        }
        public void limpiar()
        {
            textBox2.Clear();
            label3.Text = "";
            textBox4.Clear();
            textBox3.Text = "1";
            
        }
        public decimal vtatotal()
        {
            return VTATOTAL;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dRe = new DialogResult();
            decimal vta1 = vtatotal();
            string vta = vta1.ToString();
            vta = vta.Replace(",", ".");
            dRe = MessageBox.Show("Esta seguro de cerrar la Mesa con Importe " + label7.Text, "Cierre Mesa", MessageBoxButtons.OKCancel);
            if (dRe == DialogResult.OK)
            {
                string cmdtext;
                DataTable dt = new DataTable();
                if (nombre13 != "PADEL")
                {
                    
                    cmdtext = "select nro from contador";
                    
                    dt = oacceso.leerDatos(cmdtext);
                    cmdtext = "update contador set nro = nro + 1";                    
                    oacceso.ActualizarBD(cmdtext);
                    int nro = 0;cmdtext = "select caja from cajas where id_fin = '0'";
                    foreach (DataRow dr in dt.Rows)
                    {
                        nro = Convert.ToInt32(dr["nro"]) + 1;

                    }
                    cmdtext = "select caja from cajas where id_fin = '0'";
                    dt = oacceso.leerDatos(cmdtext);
                    int caja = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        caja = Convert.ToInt32(dr["caja"]);
                    }
                    string fecha1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string fecha2 = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                    cmdtext = "insert into ventas(total, nrocomp, fecha, idcajas) values('" + vta + "','" + nro + "','" + fecha2 + "','"+caja+"')";
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
                }
                else
                {
                    /*cmdtext = "insert into movifinal(idart, idmesa, cantidad, total, idventas) select idart, idmesa, cantidad, total, '" + id + "' from movipadel where idmesa = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);
                    cmdtext = "delete from movipadel where idmesa = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);*/
                    cmdtext = "update movipadel set estado = 1 where idmesa = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);
                }
                cmdtext = "select idart, cantidad from movifinal where idventas = (select max(idventas) from movifinal)";
                dt = oacceso.leerDatos(cmdtext);
                foreach(DataRow dr in dt.Rows)
                {
                    cmdtext = "update articulos set stock = stock - '" + Convert.ToInt32(dr["cantidad"]) +"' where idarticulos = '" + Convert.ToInt32(dr["idart"]) +"'";
                    oacceso.ActualizarBD(cmdtext);
                }
            }
            this.Close();
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
                        if (nombre12 == "CALLE 1")
                        {
                            label3.Text = Convert.ToString(dr["idarticulos"]);
                            textBox2.Text = Convert.ToString(dr["descripcion"]);
                            int preciocalle = Convert.ToInt32(dr["preciocalle"]);
                            if (entro == true)
                            {
                                break;
                            }
                            else
                            {
                                if (preciocalle == 0)
                                {
                                    MessageBox.Show("El producto elegido no posee Precio Mostrador, se vendera al Precio Confiteria");
                                    textBox4.Text = Convert.ToString(dr["precio"]);
                                    entro = false;
                                    break;
                                }
                                else
                                {
                                    textBox4.Text = Convert.ToString(dr["preciocalle"]);
                                    break;
                                }

                            }
                        }
                        else
                        {
                            label3.Text = Convert.ToString(dr["idarticulos"]);
                            textBox2.Text = Convert.ToString(dr["descripcion"]);
                            textBox4.Text = Convert.ToString(dr["precio"]);
                        }
                        if (label3.Text != "")
                        {
                            textBox3.Focus();
                        }
                    }
                }
            }
            
                
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cmdtext = "select descripcion, idarticulos, precio, preciocalle from articulos where codbarra = '" + textBox1.Text + "'";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                if (nombre12 == "CALLE 1")
                {
                    //textBox5.Text = Convert.ToString(dr["idarticulos"]);
                    textBox2.Text = Convert.ToString(dr["descripcion"]);
                    int preciocalle = Convert.ToInt32(dr["preciocalle"]);
                    if (preciocalle == 0)
                    {
                        MessageBox.Show("El producto elegido no posee Precio Mostrador, se vendera al Precio Confiteria");
                        textBox4.Text = Convert.ToString(dr["precio"]);
                        entro = true;
                        break;
                    }
                    else
                    {
                        textBox4.Text = Convert.ToString(dr["preciocalle"]);
                        break;
                    }
                }
                else
                {
                    textBox5.Text = Convert.ToString(dr["idarticulos"]);
                    textBox2.Text = Convert.ToString(dr["descripcion"]);
                    textBox4.Text = Convert.ToString(dr["precio"]);
                }
            }
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            string cmdtext = "";
            int count = 0;
            DataTable dt = new DataTable();
            if (nombre13 != "PADEL")
            {
                cmdtext = "select count(*) as cant from movi where idmesa = '" + label1.Text + "'";
                
                dt = oacceso.leerDatos(cmdtext);
                
                foreach (DataRow dr in dt.Rows)
                {
                    count = Convert.ToInt32(dr["cant"]);
                }
            }
            else
            {
                cmdtext = "select count(*) as cant from movipadel where idmesa = '" + label1.Text + "'";
                
                dt = oacceso.leerDatos(cmdtext);
                
                foreach (DataRow dr in dt.Rows)
                {
                    count = Convert.ToInt32(dr["cant"]);
                }
            }
            if (count > 0)
            {
                if (nombre13 != "PADEL")
                {

                    int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                    string lala = this.dataGridView1.Rows[filaseleccionada].Cells[0].Value + "";
                    cmdtext = "delete from movi where idart = '" + lala + "' and idmesa = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);
                    string cmdtxt = "select idart, descripcion, cantidad, precio, total from movi inner join articulos on movi.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";

                    dt = oacceso.leerDatos(cmdtxt);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);
                    string cmdt = "select sum(total) from movi where idmesa ='" + label1.Text + "'";
                    dt = oacceso.leerDatos(cmdt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        label7.Text = "Total: $" + Convert.ToString(dr["sum(total)"]);

                    }
                }
                else
                {
                    int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                    string lala = this.dataGridView1.Rows[filaseleccionada].Cells[0].Value + "";
                    cmdtext = "delete from movipadel where idart = '" + lala + "' and idmesa = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);
                    string cmdtxt = "select idart, descripcion, cantidad, precio, total from movipadel m inner join articulos on m.idart = articulos.idarticulos where idmesa = '" + label1.Text + "'";
                    dt = oacceso.leerDatos(cmdtxt);
                    bin.DataSource = dt;
                    dataGridView1.DataSource = bin;
                    bin.ResetBindings(true);
                    string cmdt = "select sum(total) from movipadel where idmesa ='" + label1.Text + "'";
                    dt = oacceso.leerDatos(cmdt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        label7.Text = "Total: $" + Convert.ToString(dr["sum(total)"]);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay articulos disponibles para eliminar");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Convert.ToInt32(textBox3.Text) > 0)
                {
                    button1.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad valida");
                }
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
           
            
    }
}
