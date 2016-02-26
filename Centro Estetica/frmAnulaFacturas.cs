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
    public partial class frmAnulaFacturas : Form
    {
        int idfactura = 0;
        public frmAnulaFacturas()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (textBox2.Text[i] == '.')
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Acceso_BD oac = new Acceso_BD();
            try
            {
                dataGridView1.Columns.Clear();
                txtLocalidad.Text = "";
                txtDomicilio.Text = "";
                txtPaciente.Text = "";
                lbltotal.Text = "TOTAL: $0";
                idfactura = 0;
                DateTime fecha = Convert.ToDateTime(maskedTextBox1.Text);
                DataTable dt = oac.leerDatos("select f.idfacturacion as idfacturacion, l.idlineafactura as idlineafactura, f.ptoventa as ptoventa, f.factura as factura, f.fecha as fecha, l.cantidad as CANTIDAD, p.detalle as PRODUCTO, l.precioventa as 'PRECIO DE VENTA', f.detalle as detalle, f.domicilio as domicilio, f.localidad as localidad,sum(l.precioventa * l.cantidad) as total from facturacion f left join lineafactura l on f.idfacturacion = l.idfacturacion left join productos p on l.idproductos = p.idproductos where ptoventa = '" + textBox2.Text + "' and factura = '" + textBox1.Text + "' and date(fecha) = '" + fecha.ToString("yyyy-MM-dd") + "' and date(fecha) between DATE_SUB(NOW(), INTERVAL 2 DAY) and date(now()) and tipocomp = 1 group by l.idlineafactura");
                dataGridView1.DataSource = dt;
                decimal total = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    txtPaciente.Text = Convert.ToString(dr["detalle"]);
                    txtDomicilio.Text = Convert.ToString(dr["domicilio"]);
                    txtLocalidad.Text = Convert.ToString(dr["localidad"]);
                    textBox1.Text = Convert.ToString(dr["factura"]);
                    textBox2.Text = Convert.ToString(dr["ptoventa"]);
                    maskedTextBox1.Text = Convert.ToDateTime(dr["fecha"]).ToString("dd/MM/yyyy");
                    idfactura = Convert.ToInt32(dr["idfacturacion"]);
                    total = total + Convert.ToDecimal(dr["total"]);                    
                }
                lbltotal.Text = "TOTAL: $" + Convert.ToString(total);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }

        private void frmAnulaFacturas_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idfactura != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de Anular el comprobante?", "Anula Comprobante", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Acceso_BD oc = new Acceso_BD();
                        DataTable dt = oc.leerDatos("select ifnull(t.idserviciosturnos,0) as id from facturacion f left join lineafactura l on f.idfacturacion = l.idfacturacion left join servicios s on l.idlineafactura = s.idlineafactura left join serviciosturnos t on s.idservicios = t.idservicios where f.idfacturacion = '"+idfactura+"'");
                        int id = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = Convert.ToInt32(dr["id"]);
                            if (id != 0)
                            {
                                break;
                            }
                        }
                        if (id == 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Imposible eliminar comprobante, servicios ya asignados a turnos");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe primero traer un comprobante valido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
