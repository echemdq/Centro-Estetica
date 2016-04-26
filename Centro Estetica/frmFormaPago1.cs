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
    public partial class frmFormaPago1 : Form
    {
        Factura fact = null;
        List<Ctacte> lista1 = new List<Ctacte>();
        ControladoraFacturacion controlf = new ControladoraFacturacion();
        public frmFormaPago1(Factura f, List<Ctacte> lista)
        {
            InitializeComponent();
            fact = f;
            lista1 = lista;
        }

        private void frmFormaPago1_Load(object sender, EventArgs e)
        {
            Acceso_BD oacceso = new Acceso_BD();
            DataTable dt = oacceso.leerDatos("select * from tipoformaspago order by tipo asc");
            List<TipoFormasPago> listat = new List<TipoFormasPago>();
            foreach (DataRow dr in dt.Rows)
            {
                TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(dr["idtipoformaspago"]), Convert.ToString(dr["tipo"]), "", "", "",0);
                listat.Add(t);
            }
            cmbFormaPago.DataSource = listat;
            cmbFormaPago.DisplayMember = "forma";
            cmbFormaPago.ValueMember = "idtipoformaspago";
            cmbFormaPago.SelectedIndex = 1;
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

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text == "CUENTA CORRIENTE")
            {
                cmbFormaPago.SelectedIndex = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkFactura.Checked && txtPtoVenta.Text != "" && txtFactura.Text != "")
                {
                    fact.Ptoventa = Convert.ToInt32(txtPtoVenta.Text);
                    fact.Numerofact = Convert.ToInt32(txtFactura.Text);
                    TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "",0);
                    if (cmbFormaPago.Text == "TARJETA DE CREDITO" || cmbFormaPago.Text == "TARJETA DE DEBITO")
                    {
                        t.Idtarjetas = (Convert.ToString(cmbFormaPago.SelectedValue));
                        t.Cupon = txtCupon.Text;
                        t.Cuotas = txtCuotas.Text;
                    }
                    if (cmbFormaPago.Text != "CUENTA CORRIENTE")
                    {
                        controlf.Agregar2(fact, lista1, t);
                    }
                }
                else
                {
                    Acceso_BD oacceso = new Acceso_BD();
                    DataTable dt = oacceso.leerDatos("select numero + 1 as numero from contador where detalle = 'recibo'");
                    int factura = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        factura = Convert.ToInt32(dr["numero"]);
                    }
                    fact.Ptoventa = 0;
                    fact.Numerofact = factura;
                    TipoFormasPago t = new TipoFormasPago(Convert.ToInt32(cmbFormaPago.SelectedValue), cmbFormaPago.Text, "", "", "",0);
                    if (cmbFormaPago.Text == "TARJETA DE CREDITO" || cmbFormaPago.Text == "TARJETA DE DEBITO")
                    {
                        t.Idtarjetas = (Convert.ToString(cmbFormaPago.SelectedValue));
                        t.Cupon = txtCupon.Text;
                        t.Cuotas = txtCuotas.Text;
                    }
                    if (cmbFormaPago.Text != "CUENTA CORRIENTE")
                    {
                        controlf.Agregar2(fact, lista1, t);
                    }
                    oacceso.ActualizarBD("update contador set numero = numero + 1 where detalle = 'recibo'");
                }
                MessageBox.Show("Comprobante guardado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
