using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Permissions;
using System.Threading;
namespace BullPadel
{
    public partial class abmproductos : Form
    {
        
        //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US", false);
        bool edit = false;
        Productos aux;
        DaoProductos odao = new DaoProductos();
        public abmproductos()
        {
            InitializeComponent();
        }

        private void abmproductos_Load(object sender, EventArgs e)
        {
            limpiar();
            lectura();
        }
        public void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear(); 
            textBox5.Clear();
            textBox6.Clear();
        }
        public void lectura()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
        }
        public void editar()
        {
            edit = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar();
            textBox4.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            editar();
            textBox1.ReadOnly = true;
            edit = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int stock;
            if (textBox4.Text == "")
            {
                stock = Convert.ToInt32(null);
            }
            else
                stock = Convert.ToInt32(textBox4.Text);
            string precio = textBox3.Text.Replace(",",".");
            string preciocalle = "0";
            if (textBox6.Text == "")
            {
                preciocalle = "0";
            }
            else
                preciocalle = textBox6.Text.Replace(",", ".");
            
            aux = new Productos(0, textBox2.Text, precio, textBox5.Text, stock, null, preciocalle);
            if (edit == true)
            {
                int id = Convert.ToInt32(textBox1.Text);
                odao.update(id, aux);
            }
            else
            {
                odao.agregar(aux);
            }
            edit = false;
            limpiar();
            lectura();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscarproducto frm = new buscarproducto();
            frm.ShowDialog();
            aux = frm.devolver();
            if (aux != null)
            {
                textBox1.Text = aux.Id.ToString();
                textBox2.Text = aux.Descripcion;
                textBox3.Text = aux.Precio.ToString();
                textBox4.Text = aux.Stock.ToString();
                textBox5.Text = aux.Codigobarra;
                textBox6.Text = aux.Preciocalle;
            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Seguro", "Eliminar", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    odao.eliminar(Convert.ToInt32(textBox1.Text));
                    limpiar();
                }
              
                    
           
                
            }
            else
                MessageBox.Show("No hay ningun articulo disponible para eliminar");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == 13)
            {
                if (textBox1.Text != "")
                {

                    aux = odao.devolverprod(Convert.ToInt32(textBox1.Text));
                    if (aux != null)
                    {
                        textBox1.Text = aux.Id.ToString();
                        textBox2.Text = aux.Descripcion;
                        textBox3.Text = aux.Precio.ToString();
                        textBox4.Text = aux.Stock.ToString();
                        textBox5.Text = aux.Codigobarra;
                        textBox6.Text = aux.Preciocalle;
                    }
                    else
                    {
                        MessageBox.Show("El codigo no existe");
                        limpiar();
                    }
                }
                else
                    limpiar();
            }           
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                aux = odao.devolverprod(Convert.ToInt32(textBox1.Text));
                if (aux != null)
                {
                    textBox1.Text = aux.Id.ToString();
                    textBox2.Text = aux.Descripcion;
                    textBox3.Text = aux.Precio.ToString();
                    textBox4.Text = aux.Stock.ToString();
                    textBox5.Text = aux.Codigobarra;
                }
                else
                {
                    MessageBox.Show("El codigo no existe");
                    limpiar();
                }
            }
            else
                limpiar();
        }

        
    }
}
