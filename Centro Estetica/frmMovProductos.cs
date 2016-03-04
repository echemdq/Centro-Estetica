using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class frmMovProductos : Form
    {
        ControladoraProductos controlprod = new ControladoraProductos();
        ControladoraMovProductos controlmov = new ControladoraMovProductos();
        Productos prod = null;
        List<MovProductos> lista = new List<MovProductos>();
        public frmMovProductos()
        {
            InitializeComponent();
        }

        private void frmMovProductos_Load(object sender, EventArgs e)
        {
            txtTipo.Text = "INGRESO";
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[1].Name = "Detalle";
            dataGridView1.Columns[2].Name = "Cantidad";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    prod = controlprod.Buscar(txtCodigo.Text);
                    if (prod != null && prod.Sesiones == 0)
                    {
                        txtCodigo.Text = prod.Idproductos.ToString();
                        txtProducto.Text = prod.Detalle;
                        txtCant.Focus();
                    }
                    else
                    {
                        prod = null;
                        MessageBox.Show("Debe seleccionar un producto, no un servicio");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaProductos frm = new frmBuscaProductos();
                frm.ShowDialog();
                prod = frm.u;
                if (prod != null && prod.Sesiones == 0)
                {
                    txtCodigo.Text = prod.Idproductos.ToString();
                    txtProducto.Text = prod.Detalle;
                    txtCant.Focus();
                }
                else
                {
                    prod = null;
                    MessageBox.Show("Debe seleccionar un producto, no un servicio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod != null && Convert.ToInt32(txtCant.Text) > 0)
                {
                    dataGridView1.Rows.Clear();
                    string consignacion = "0";
                    if (checkBox1.Checked)
                    {
                        consignacion = "1";
                    }
                    MovProductos f = new MovProductos(0, txtDetalle.Text, txtResponsable.Text, prod.Idproductos, txtProducto.Text, Convert.ToInt32(txtCant.Text), txtTipo.Text, consignacion);
                    if (lista.Count > 0)
                    {
                        int flag = 0;
                        foreach (MovProductos fe in lista)
                        {
                            flag = 0;
                            if (fe.Idproductos == prod.Idproductos)
                            {
                                fe.Cantidad = fe.Cantidad + f.Cantidad;
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            lista.Add(f);
                        }
                    }
                    else
                    {
                        lista.Add(f);
                    }
                    int x = 0;
                    if (lista.Count > 0)
                    {
                        dataGridView1.Rows.Add(lista.Count());
                        foreach (MovProductos fa in lista)
                        {
                            dataGridView1.Rows[x].Cells[0].Value = fa.Idproductos;
                            dataGridView1.Rows[x].Cells[1].Value = fa.Producto;
                            dataGridView1.Rows[x].Cells[2].Value = fa.Cantidad;
                            x++;
                        }
                    }              
                }
                prod = null;
                txtCodigo.Text = "";
                txtCant.Text = "1";
                txtProducto.Text = "";
                button1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista.Count > 0)
                {
                    foreach (MovProductos a in lista)
                    {
                        if (checkBox1.Checked)
                        {
                            a.Consignacion = "1";
                        }
                        else
                        {
                            a.Consignacion = "0";
                        }
                        a.Responsable = txtResponsable.Text;
                        a.Detalle = txtDetalle.Text;
                        a.Tipomov = txtTipo.Text;
                        controlmov.Agregar(a);                        
                    }
                    dataGridView1.Rows.Clear();
                    lista.Clear();
                    txtTipo.Text = "INGRESO";
                    checkBox1.Checked = false;
                    txtResponsable.Text = "";
                    txtDetalle.Text = "";
                    prod = null;
                    txtCodigo.Text = "";
                    txtProducto.Text = "";
                    txtCant.Text = "";
                    MessageBox.Show("Movimiento cargado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dataGridView1.CurrentRow.Index;
                if (dataGridView1.Rows[fila].Cells[1].Value.ToString() != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el producto: " + dataGridView1.Rows[fila].Cells[1].Value.ToString(), "Eliminar producto", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int flag = 0;
                        
                        MovProductos mo = new MovProductos(0, "", "", 0, "", 0, "", "");
                        foreach (MovProductos fe in lista)
                        {
                            if (fe.Idproductos == Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value))
                            {
                                flag = 1;
                                mo = fe;
                                break;
                            }
                        }
                        if (flag == 1)
                        {
                            lista.Remove(mo);
                        }
                        dataGridView1.Rows.Clear();
                        int x = 0;
                        if (lista.Count > 0)
                        {
                            dataGridView1.Rows.Add(lista.Count());
                            foreach (MovProductos fa in lista)
                            {
                                dataGridView1.Rows[x].Cells[0].Value = fa.Idproductos;
                                dataGridView1.Rows[x].Cells[1].Value = fa.Producto;
                                dataGridView1.Rows[x].Cells[2].Value = fa.Cantidad;
                                x++;
                            }
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
