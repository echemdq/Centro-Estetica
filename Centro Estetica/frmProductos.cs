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
    public partial class frmProductos : Form
    {
        ControladoraProductos controlp = new ControladoraProductos();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtPrecioV.Text.Length; i++)
            {
                if (txtPrecioV.Text[i] == '.')
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

        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtPrecioC.Text.Length; i++)
            {
                if (txtPrecioC.Text[i] == '.')
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
        }

        public void habilitar()
        {
            txtPrecioC.Enabled = true;
            txtPrecioV.Enabled = true;
            txtProducto.Enabled = true;
            txtSesiones.Enabled = true;
            txtStock.Enabled = true;
        }
        public void deshabilitar()
        {
            txtPrecioC.Enabled = false;
            txtPrecioV.Enabled = false;
            txtProducto.Enabled = false;
            txtSesiones.Enabled = false;
            txtStock.Enabled = false;
        }
        public void limpiar()
        {
            textBox1.Text = "";
            txtStock.Text = "0";
            txtSesiones.Value = 0;
            txtProducto.Text = "";
            txtPrecioV.Text = "0.00";
            txtPrecioC.Text = "0.00";
            lblId.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProducto.Text != "")
                {
                    int activo = 1;
                    if (!chkActivo.Checked)
                    {
                        activo = 0;
                    }
                    else
                    {
                        activo = 1;
                    }
                    Productos p = new Productos(0, txtProducto.Text, Convert.ToDecimal(txtPrecioV.Text.Replace('.', ',')), Convert.ToInt32(txtSesiones.Value), Convert.ToInt32(txtStock.Text), activo, Convert.ToDecimal(txtPrecioC.Text.Replace('.', ',')));
                    if (lblId.Text == "")
                    {
                        controlp.Agregar(p);
                        MessageBox.Show("Producto guardado correctamente");
                    }
                    else
                    {
                        p.Idproductos = Convert.ToInt32(lblId.Text);
                        controlp.Modificar(p);
                        MessageBox.Show("Producto modificado correctamente");
                    }
                    limpiar();
                    deshabilitar();
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre y apellido del Profesional");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                deshabilitar();
                limpiar();
                frmBuscaProductos frm = new frmBuscaProductos();
                frm.ShowDialog();
                Productos u = frm.u;
                if (u != null)
                {
                    textBox1.Text = u.Idproductos.ToString();
                    lblId.Text = Convert.ToString(u.Idproductos);
                    txtProducto.Text = u.Detalle;
                    txtSesiones.Value = u.Sesiones;
                    txtStock.Text = u.Stock.ToString();
                    txtPrecioV.Text = u.Precioventa.ToString().Replace(',','.');
                    txtPrecioC.Text = u.Preciocalculo.ToString().Replace(',', '.');
                    if (u.Activo == 0)
                    {
                        chkActivo.Checked = false;
                        //tabPageCargaEmpleados.BackColor = Color.LightCoral;
                    }
                    else if (u.Activo == 1)
                    {
                        chkActivo.Checked = true;
                        //tabPageCargaEmpleados.BackColor = SystemColors.Info;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                habilitar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "")
                {
                    Productos r = new Productos(Convert.ToInt32(lblId.Text), "", 0, 0, 0, 0, 0);
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el Producto: " + txtProducto.Text, "Eliminar Producto", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        controlp.Borrar(r);
                        limpiar();
                        deshabilitar();
                        MessageBox.Show("Producto eliminado correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Producto para eliminarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }
    }
}
