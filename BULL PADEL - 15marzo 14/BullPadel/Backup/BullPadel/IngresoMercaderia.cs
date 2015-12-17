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
    public partial class IngresoMercaderia : Form
    {
        Productos oprod;
        AccesoBD oacceso = new AccesoBD();
        BindingSource bin = new BindingSource();
        static string caja;
        static DateTime fech;
        public IngresoMercaderia()
        {
            InitializeComponent();
        }

        private void IngresoMercaderia_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();           
            string cmdtext = "select case when id_fin = '0' then caja else 'error' end as caja, fecha from cajas";
            dt = oacceso.leerDatos(cmdtext);
            
            foreach(DataRow dr in dt.Rows)
            {
                caja = Convert.ToString(dr["caja"]);
                fech = Convert.ToDateTime(dr["fecha"]);
            }
            maskedTextBox1.Text = fech.ToString("dd-MM-yyyy");
            cmdtext = "select idart, detalle, cantidad from movingreso";           
            dt = oacceso.leerDatos(cmdtext);            
            bin.DataSource = dt;
            dataGridView1.DataSource = bin;
            bin.ResetBindings(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarproducto frm = new buscarproducto();
            frm.ShowDialog();
            oprod = frm.devolver();
            if (oprod != null)
            {               
                textBox5.Text = oprod.Id.ToString();
                textBox4.Text = oprod.Descripcion;                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                //DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                string fecha = fech.ToString("yyyy-MM-dd HH:mm:ss");
                string cmdtext = "insert into movingreso(idart, detalle, cantidad) values ('" + textBox5.Text + "','" + textBox4.Text+"','" + textBox3.Text +"')";
                oacceso.ActualizarBD(cmdtext);
                cmdtext = "select idart, detalle, cantidad from movingreso";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                bin.DataSource = dt;
                dataGridView1.DataSource = bin;
                bin.ResetBindings(true);
            }
            else
            {
                MessageBox.Show("Asegurese de completar los campos Proveedor y Nro Comprobante");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(caja != "error")
            {
                string cmdtext = "select idart, cantidad from movingreso";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                int idart = 0;
                int cant;
                foreach (DataRow dr in dt.Rows)
                {
                    idart = Convert.ToInt32(dr["idart"]);
                    cant = Convert.ToInt32(dr["cantidad"]);
                    cmdtext = "update articulos set stock = stock + '" + cant + "' where idarticulos = '" + idart + "'";
                    oacceso.ActualizarBD(cmdtext);
                }
                //DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                string fecha = fech.ToString("yyyy-MM-dd HH:mm:ss");
                if (checkBox1.Checked == true)
                {
                    cmdtext = "insert into gastos(caja,detalle,importe,fecha) values('" + caja + "','" + textBox1.Text + "','" + textBox6.Text + "','" + fecha + "')";
                    oacceso.ActualizarBD(cmdtext);
                }
                cmdtext = "insert into ingreso(proveedor, nrocomp, fecha, importe, caja) values('" + textBox1.Text + "','" + textBox2.Text + "','" + fecha + "','" + textBox6.Text + "','" + caja + "')";
                oacceso.ActualizarBD(cmdtext);
                cmdtext = "select max(idingreso) as id from ingreso";
                dt = oacceso.leerDatos(cmdtext);
                int id = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    id = Convert.ToInt32(dr["id"]);
                }
                cmdtext = "insert into movingresofinal(idart, cantidad, idingreso) select idart, cantidad, '" + id + "' from movingreso where idmovingreso <> '0'";
                oacceso.ActualizarBD(cmdtext);
                cmdtext = "delete from movingreso where idmovingreso <> '0'";
                oacceso.ActualizarBD(cmdtext);
                if (idart != 0)
                {
                    this.Close();
                    MessageBox.Show("Stock Actualizado Correctamente");
                }
                else
                {
                    MessageBox.Show("Imposible realizar esta operacion");
                }
            }
            else 
            {
                MessageBox.Show("No se encuentra abierta ninguna caja");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string cmdtext;
                if (Convert.ToInt32(textBox5.Text) < 1000000)
                {
                    cmdtext = "select descripcion from articulos where idarticulos = '" + textBox5.Text + "'";
                }
                else
                {
                    cmdtext = "select descripcion from articulos where codbarra = '" + textBox5.Text + "'";
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
                        textBox4.Text = Convert.ToString(dr["descripcion"]);
                    }
                    textBox3.Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmdtext = "select count(*) as cant from movingreso";
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
                cmdtext = "delete from movingreso where idart = '" + lala + "'";
                oacceso.ActualizarBD(cmdtext);
                cmdtext = "select idart, detalle, cantidad from movingreso";                
                dt = oacceso.leerDatos(cmdtext);
                bin.DataSource = dt;
                dataGridView1.DataSource = bin;
                bin.ResetBindings(true);
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
                    button3.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad valida");
                }
            }
        }
    }
}
