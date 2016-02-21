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
    public partial class frmFormaPago : Form
    {
        Factura fact = null;
        List<Facturacion> lista1 = new List<Facturacion>();
        ControladoraFacturacion controlf = new ControladoraFacturacion();
        public frmFormaPago(Factura f, List<Facturacion> lista)
        {
            InitializeComponent();
            fact = f;
            lista1 = lista;
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtCuotas.Text.Length; i++)
            {
                if (txtCuotas.Text[i] == '.')
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

        private void txtCupon_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtCupon.Text.Length; i++)
            {
                if (txtCupon.Text[i] == '.')
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

        private void txtPtoVenta_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtPtoVenta.Text.Length; i++)
            {
                if (txtPtoVenta.Text[i] == '.')
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

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtFactura.Text.Length; i++)
            {
                if (txtFactura.Text[i] == '.')
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFormaPago.Text == "TARJETA DE CREDITO" || cmbFormaPago.Text == "TARJETA DE DEBITO")
                {
                    if (chkFactura.Checked)
                    {
                        if (txtPtoVenta.Text != "" && txtFactura.Text != "" && txtCuotas.Text != "" && txtCupon.Text != "" && cmbTarjetas.Text != "")
                        {
                            fact.Ptoventa = Convert.ToInt32(txtPtoVenta.Text);
                            fact.Numerofact = Convert.ToInt32(txtFactura.Text);
                            TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "");
                            t.Idtarjetas = (Convert.ToString(cmbTarjetas.SelectedValue));
                            t.Cupon = txtCupon.Text;
                            t.Cuotas = txtCuotas.Text;
                            controlf.Agregar(fact, lista1, t);
                            MessageBox.Show("Comprobante guardado exitosamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe completar los datos de la factura, pto de venta, tarjeta, cuotas y nro de cupon");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe cargar los datos de la factura");
                    }
                }
                else if (cmbFormaPago.Text == "EFECTIVO")
                {
                    if (chkFactura.Checked)
                    {
                        if (txtPtoVenta.Text != "" && txtFactura.Text != "")
                        {
                            fact.Ptoventa = Convert.ToInt32(txtPtoVenta.Text);
                            fact.Numerofact = Convert.ToInt32(txtFactura.Text);
                            TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "");
                            controlf.Agregar(fact, lista1, t);
                            MessageBox.Show("Comprobante guardado exitosamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe completar los datos de la factura y pto de venta");
                        }
                    }
                    else
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select numero + 1 as numero from contador where detalle = 'factura'");
                        int factura = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            factura = Convert.ToInt32(dr["numero"]);
                        }
                        fact.Ptoventa = 0;
                        fact.Numerofact = factura;
                        TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "");
                        controlf.Agregar(fact, lista1, t);
                        oacceso.ActualizarBD("update contador set numero = numero + 1 where detalle = 'factura'");
                        MessageBox.Show("Comprobante guardado exitosamente");
                        this.Close();
                    }
                }
                else if (cmbFormaPago.Text == "CUENTA CORRIENTE")
                {
                    if (chkFactura.Checked)
                    {
                        if (txtPtoVenta.Text != "" && txtFactura.Text != "")
                        {
                            fact.Ptoventa = Convert.ToInt32(txtPtoVenta.Text);
                            fact.Numerofact = Convert.ToInt32(txtFactura.Text);
                            TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "");
                            if (fact.Idpaciente != 0)
                            {
                                controlf.Agregar1(fact, lista1, t);
                                MessageBox.Show("Comprobante guardado exitosamente");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Para facturar en cuenta corriente debe seleccionar un cliente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe completar los datos de la factura y pto de venta");
                        }
                    }
                    else
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select numero + 1 as numero from contador where detalle = 'factura'");
                        int factura = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            factura = Convert.ToInt32(dr["numero"]);
                        }
                        fact.Ptoventa = 0;
                        fact.Numerofact = factura;
                        TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "");
                        if (fact.Idpaciente != 0)
                        {
                            controlf.Agregar1(fact, lista1, t);
                            oacceso.ActualizarBD("update contador set numero = numero + 1 where detalle = 'factura'");
                            MessageBox.Show("Comprobante guardado exitosamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Para facturar en cuenta corriente debe seleccionar un cliente");
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFormaPago_Load(object sender, EventArgs e)
        {
            Acceso_BD oacceso = new Acceso_BD();
            DataTable dt = oacceso.leerDatos("select * from tipoformaspago order by tipo asc");
            List<TipoFormasPago> listat = new List<TipoFormasPago>();
            foreach (DataRow dr in dt.Rows)
            {
                TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(dr["idtipoformaspago"]), Convert.ToString(dr["tipo"]),"","","");
                listat.Add(t);
            }
            cmbFormaPago.DataSource = listat;
            cmbFormaPago.DisplayMember = "forma";
            cmbFormaPago.ValueMember = "idtipoformaspago";
            cmbFormaPago.SelectedIndex = 0;
            cmbFormaPago.Text = "EFECTIVO";

            dt = oacceso.leerDatos("select * from tarjetas order by tarjeta asc");
            List<Tarjetas> listata = new List<Tarjetas>();
            foreach (DataRow dr in dt.Rows)
            {
                Tarjetas t = new Tarjetas(Convert.ToInt32(dr["idtarjetas"]), Convert.ToString(dr["tarjeta"]));
                listata.Add(t);
            }
            cmbTarjetas.DataSource = listata;
            cmbTarjetas.DisplayMember = "tarjeta";
            cmbTarjetas.ValueMember = "idtarjetas";
            cmbTarjetas.SelectedIndex = 0;
            cmbTarjetas.SelectedItem = null;
            txtTotal.Text = fact.Total.ToString();
        }

        private void chkFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFactura.Checked)
            {
                txtPtoVenta.Enabled = true;
                txtFactura.Enabled = true;
            }
            else
            {
                txtPtoVenta.Enabled = false;
                txtFactura.Enabled = false;
            }
        }
    }
}
