﻿using System;
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
    public partial class frmFactura : Form
    {
        List<Facturacion> listaf = new List<Facturacion>();
        Productos prod = null;
        Pacientes pac = null;
        ControladoraProductos controlprod = new ControladoraProductos();
        ControladoraPacientes controlpac = new ControladoraPacientes();
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "idfacturacion";
            dataGridView1.Columns[1].Name = "Detalle";
            dataGridView1.Columns[2].Name = "Cantidad";
            dataGridView1.Columns[3].Name = "Precio";
            dataGridView1.Columns[4].Name = "idproducto";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaPacientes frm = new frmBuscaPacientes();
                frm.ShowDialog();
                pac = frm.u;
                if (pac != null)
                {
                    txtPaciente.Text = pac.Paciente;
                    txtDocumento.Text = pac.Documento;
                    txtDomicilio.Text = pac.Domicilio;
                    button1.Focus();
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
                if (prod != null)
                {
                    txtCodigo.Text = prod.Idproductos.ToString();
                    txtProducto.Text = prod.Detalle;
                    txtPrecio.Text = prod.Precioventa.ToString();
                    txtCant.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtCant.Text.Length; i++)
            {
                if (txtCant.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                decimal precio = 0;
                if (prod != null)
                {
                    Facturacion f = new Facturacion(0, prod, Convert.ToInt32(txtCant.Text));
                    if (listaf.Count > 0)
                    {
                        int flag = 0;
                        foreach (Facturacion fe in listaf)
                        {
                            flag = 0;
                            if (fe.P.Idproductos == prod.Idproductos)
                            {
                                fe.Cantidad = fe.Cantidad + f.Cantidad;
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            listaf.Add(f);
                        }
                    }
                    else
                    {
                        listaf.Add(f);
                    }
                    int x = 0;
                    if (listaf.Count > 0)
                    {
                        dataGridView1.Rows.Add(listaf.Count());
                        foreach (Facturacion fa in listaf)
                        {
                            dataGridView1.Rows[x].Cells[0].Value = fa.Idfacturacion;
                            dataGridView1.Rows[x].Cells[1].Value = fa.P.Detalle;
                            dataGridView1.Rows[x].Cells[2].Value = fa.Cantidad;
                            dataGridView1.Rows[x].Cells[3].Value = fa.P.Precioventa * fa.Cantidad;
                            dataGridView1.Rows[x].Cells[4].Value = fa.P.Idproductos;
                            decimal precio1 = fa.P.Precioventa * fa.Cantidad;
                            x++;
                            precio = precio + precio1;
                        }
                        lbltotal.Text = precio.ToString();
                    }
                }
                prod = null;
                txtCodigo.Text = "";
                txtCant.Text = "1";
                txtProducto.Text = "";
                txtPrecio.Text = "";
                button1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentRow.Index;
            decimal precio = 0;
            if (dataGridView1.Rows[fila].Cells[1].Value.ToString() != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el producto: " + dataGridView1.Rows[fila].Cells[1].Value.ToString(), "Eliminar producto de facturacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int flag = 0;
                    Facturacion fa = new Facturacion(0, null, 0);
                    foreach (Facturacion fe in listaf)
                    {
                        if (fe.P.Idproductos == Convert.ToInt32(dataGridView1.Rows[fila].Cells[4].Value))
                        {
                            flag = 1;
                            fa = fe;
                            break;
                        }
                    }
                    if (flag == 1)
                    {
                        listaf.Remove(fa);
                    }
                    dataGridView1.Rows.Clear();
                    int x = 0;
                    if (listaf.Count > 0)
                    {
                        dataGridView1.Rows.Add(listaf.Count());
                        foreach (Facturacion fac in listaf)
                        {
                            dataGridView1.Rows[x].Cells[0].Value = fac.Idfacturacion;
                            dataGridView1.Rows[x].Cells[1].Value = fac.P.Detalle;
                            dataGridView1.Rows[x].Cells[2].Value = fac.Cantidad;
                            dataGridView1.Rows[x].Cells[3].Value = fac.P.Precioventa * fac.Cantidad;
                            dataGridView1.Rows[x].Cells[4].Value = fac.P.Idproductos;
                            decimal precio1 = fac.P.Precioventa * fac.Cantidad;
                            x++;
                            precio = precio + precio1;
                        }
                        lbltotal.Text = precio.ToString();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idpaciente = 0;
                if(pac != null)
                {
                    idpaciente = pac.Idpacientes;
                }
                Factura f = new Factura(0, DateTime.Now, idpaciente, txtPaciente.Text, txtDomicilio.Text, txtDocumento.Text, txtLocalidad.Text, Convert.ToDecimal(lbltotal.Text),0,0);
                frmFormaPago frm = new frmFormaPago(f, listaf);
                frm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
