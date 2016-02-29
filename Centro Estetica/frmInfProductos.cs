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
    public partial class frmInfProductos : Form
    {
        Productos prod = null;
        ControladoraProductos controlprod = new ControladoraProductos();

        public frmInfProductos()
        {
            InitializeComponent();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    prod = controlprod.Buscar(txtCodigo.Text);
                    if (prod != null)
                    {
                        txtCodigo.Text = prod.Idproductos.ToString();
                        txtProducto.Text = prod.Detalle;
                    }
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
                if (prod != null)
                {
                    dataGridView1.Columns.Clear();
                    Acceso_BD oa = new Acceso_BD();
                    DateTime desde = Convert.ToDateTime(maskedTextBox1.Text);
                    DateTime hasta = Convert.ToDateTime(maskedTextBox2.Text);
                    DataTable dt = new DataTable();
                    if (!checkBox1.Checked)
                    {
                        dt = oa.leerDatos("select 'lf' as tipo, cast(substring(date(f.fecha),1,10) as char) as Fecha, concat('EGRESO POR PTOVENTA ', CAST(f.ptoventa as CHAR), ' FACTURA ', CAST(f.factura as CHAR)) as Comprobante,p.detalle as Producto, l.cantidad as Cantidad, l.idlineafactura as la from lineafactura l left join productos p on l.idproductos = p.idproductos left join facturacion f on l.idfacturacion = f.idfacturacion where l.idproductos = '" + prod.Idproductos + "' and f.fecha between '" + desde.ToString("yyyy-MM-dd") + "' and '" + hasta.ToString("yyyy-MM-dd") + "' union select 'mp' as tipo, cast(substring(fecha,1,10) as char) as Fecha, concat(CAST(tipomov as CHAR), ' POR REMITO MANUAL') as Comprobante,producto as Producto, cantidad as Cantidad, idmovproductos as la from movproductos where idproductos = '" + prod.Idproductos + "' and fecha between '" + desde.ToString("yyyy-MM-dd") + "' and '" + hasta.ToString("yyyy-MM-dd") + "' and consignacion = 0");
                    }
                    else
                    {
                        dt = oa.leerDatos("select 'lf' as tipo, cast(substring(date(f.fecha),1,10) as char) as Fecha, concat('EGRESO POR PTOVENTA ', CAST(f.ptoventa as CHAR), ' FACTURA ', CAST(f.factura as CHAR)) as Comprobante,p.detalle as Producto, l.cantidad as Cantidad, l.idlineafactura as la from lineafactura l left join productos p on l.idproductos = p.idproductos left join facturacion f on l.idfacturacion = f.idfacturacion where l.idproductos = '" + prod.Idproductos + "' and f.fecha between '" + desde.ToString("yyyy-MM-dd") + "' and '" + hasta.ToString("yyyy-MM-dd") + "' union select 'mp' as tipo, cast(substring(fecha,1,10) as char) as Fecha, concat(CAST(tipomov as CHAR), ' POR REMITO MANUAL A CONSIGNACION') as Comprobante,producto as Producto, cantidad as Cantidad, idmovproductos as la from movproductos where idproductos = '" + prod.Idproductos + "' and fecha between '" + desde.ToString("yyyy-MM-dd") + "' and '" + hasta.ToString("yyyy-MM-dd") + "' and consignacion = 1");
                    }
                    dataGridView1.ColumnCount = 4;
                    dataGridView1.Columns[0].Name = "Fecha";
                    dataGridView1.Columns[1].Name = "Comprobante";
                    dataGridView1.Columns[2].Name = "Producto";
                    dataGridView1.Columns[3].Name = "Cantidad";
                    int x = 0;
                    dataGridView1.Rows.Clear();
                    int count = dt.Rows.Count;
                    if (count > 0)
                    {
                        dataGridView1.Rows.Add(count);
                        foreach (DataRow dr in dt.Rows)
                        {
                            dataGridView1.Rows[x].Cells[0].Value = Convert.ToString(dr["Fecha"]); ;
                            dataGridView1.Rows[x].Cells[1].Value = Convert.ToString(dr["Comprobante"]);
                            dataGridView1.Rows[x].Cells[2].Value = Convert.ToString(dr["Producto"]);
                            dataGridView1.Rows[x].Cells[3].Value = Convert.ToString(dr["Cantidad"]);
                            x++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto para generar el informe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
