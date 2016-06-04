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
        decimal total = -1;
        List<TipoFormasPago> laux = new List<TipoFormasPago>();
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
                if (total == -1)
                {
                    total = fact.Total;
                }
                if (total > 0)
                {
                    if (total >= Convert.ToDecimal(txtTotal.Text))
                    {

                        if (cmbFormaPago.Text == "TARJETA DE CREDITO" || cmbFormaPago.Text == "TARJETA DE DEBITO")
                        {
                            if (txtCuotas.Text != "" && txtCupon.Text != "" && cmbTarjetas.Text != "")
                            {
                                total = total - Convert.ToDecimal(txtTotal.Text);
                                TipoFormasPago tip = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, Convert.ToString(cmbTarjetas.SelectedValue), txtCuotas.Text, txtCupon.Text, Convert.ToDecimal(txtTotal.Text));
                                laux.Add(tip);
                            }
                            else
                            {
                                MessageBox.Show("Debe completar los datos de la factura, pto de venta, tarjeta, cuotas y nro de cupon");
                            }
                        }
                        else
                        {
                            total = total - Convert.ToDecimal(txtTotal.Text);
                            TipoFormasPago tip = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, Convert.ToString(cmbTarjetas.SelectedValue), txtCuotas.Text, txtCupon.Text, Convert.ToDecimal(txtTotal.Text));
                            laux.Add(tip);
                        }

                        if (total == 0)
                        {
                            if (chkFactura.Checked)
                            {
                                if (txtPtoVenta.Text != "" && txtFactura.Text != "")
                                {
                                    fact.Ptoventa = Convert.ToInt32(txtPtoVenta.Text);
                                    fact.Numerofact = Convert.ToInt32(txtFactura.Text);
                                    string idf = "0";
                                    idf = controlf.Agregar(fact, lista1);
                                    foreach (TipoFormasPago aux in laux)
                                    {
                                        if (aux.Forma == "CUENTA CORRIENTE")
                                        {
                                            controlf.AgregarFPC(aux, idf, fact.Idpaciente.ToString());
                                        }
                                        else
                                        {
                                            controlf.AgregarFP(aux, idf);
                                        }
                                    }
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
                                string idf = "0";
                                idf = controlf.Agregar(fact, lista1);
                                foreach (TipoFormasPago aux in laux)
                                {
                                    if (aux.Forma == "CUENTA CORRIENTE")
                                    {
                                        controlf.AgregarFPC(aux, idf, fact.Idpaciente.ToString());
                                    }
                                    else
                                    {
                                        controlf.AgregarFP(aux, idf);
                                    }
                                }
                            }
                            Acceso_BD oacce = new Acceso_BD();
                            oacce.ActualizarBD("update contador set numero = numero + 1 where detalle = 'factura'");
                            MessageBox.Show("Comprobante guardado exitosamente");
                            this.Close();
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.Refresh();
                            dataGridView1.DataSource = laux;
                            dataGridView1.Columns[1].Visible = false;
                            dataGridView1.Columns[2].Visible = false;
                            dataGridView1.Columns[3].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                            txtTotal.Text = total.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique el importe");
                        txtTotal.Text = total.ToString();
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
                TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(dr["idtipoformaspago"]), Convert.ToString(dr["tipo"]),"","","",0);
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
