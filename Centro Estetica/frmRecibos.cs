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
    public partial class frmRecibos : Form
    {
        ControladoraCtaCte c = new ControladoraCtaCte();
        Pacientes p = null;
        List<Ctacte> lista = new List<Ctacte>();
        public frmRecibos()
        {
            InitializeComponent();
        }

        private void frmRecibos_Load(object sender, EventArgs e)
        {           
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "idctacte";
            dataGridView1.Columns[1].Name = "Detalle";
            dataGridView1.Columns[2].Name = "Debe";
            dataGridView1.Columns[3].Name = "Cancelado";
            dataGridView1.Columns[4].Name = "A Cancelar";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                if (e.KeyChar == (char)(Keys.Escape))
                {
                    e.Handled = true;
                    dataGridView1[4, filaseleccionada].Value = "0,00";
                    decimal v1 = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        v1 += Convert.ToDecimal(row.Cells[4].Value);
                    }
                    textBox2.Text = v1.ToString();
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                decimal number;                
                if (Decimal.TryParse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Replace('.',','), out number))
                {
                    if (number <= (Convert.ToDecimal(dataGridView1[2, e.RowIndex].Value) - Convert.ToDecimal(dataGridView1[3, e.RowIndex].Value)))
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = number;
                        decimal v1 = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            v1 += Convert.ToDecimal(row.Cells[4].Value);
                        }
                        textBox2.Text = v1.ToString();
                    }
                    else
                    {

                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = "0,00";
                        decimal v1 = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            v1 += Convert.ToDecimal(row.Cells[4].Value);
                        }
                        textBox2.Text = v1.ToString();
                        MessageBox.Show("Imposible cancelar un saldo mayor al deudor");
                    }
                }
                else
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = "0,00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dataGridView1[4, e.RowIndex].Value = (Convert.ToDecimal(dataGridView1[2, e.RowIndex].Value) - Convert.ToDecimal(dataGridView1[3, e.RowIndex].Value));
                decimal v1 = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    v1 += Convert.ToDecimal(row.Cells[4].Value);
                }
                textBox2.Text = v1.ToString();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox2.Text) > 0)
            {
                try
                {
                    int idpaciente = 0;
                    if (p != null)
                    {
                        idpaciente = p.Idpacientes;
                    }
                    decimal bonif = 0;
                    Factura f = new Factura(0, DateTime.Now, idpaciente, p.Paciente, p.Domicilio, p.Documento, "", Convert.ToDecimal(textBox2.Text), 0, 0, bonif,0,"");
                    decimal v1 = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        v1 = Convert.ToDecimal(row.Cells[4].Value);
                        if (v1 > 0)
                        {
                            foreach (Ctacte aux in lista)
                            {
                                if (aux.Idctacte == Convert.ToInt32(row.Cells[0].Value))
                                {
                                    aux.Acancelar = v1;
                                    break;
                                }
                            }
                        }
                    }
                    textBox2.Text = v1.ToString();
                    frmFormaPago1 frm = new frmFormaPago1(f, lista);
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaPacientes frm = new frmBuscaPacientes();
                frm.ShowDialog();
                p = frm.u;
                if (p != null)
                {
                    textBox1.Text = p.Paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (p != null)
                {
                    lista = c.BuscarEspecial(p.Idpacientes.ToString());
                    int x = 0;
                    decimal saldo = 0;
                    if (lista.Count > 0)
                    {
                        dataGridView1.Rows.Add(lista.Count);
                        foreach (Ctacte aux in lista)
                        {
                            string detalle = "";
                            if (aux.Tipocomp == 1)
                            {
                                detalle = "FACTURA";
                            }
                            else if (aux.Tipocomp == 2)
                            {
                                detalle = "RECIBO";
                            }
                            else if (aux.Tipocomp == 3)
                            {
                                detalle = "NOTA DE CREDITO";
                            }
                            dataGridView1.Rows[x].Cells[0].Value = aux.Idctacte;
                            dataGridView1.Rows[x].Cells[1].Value = aux.Idfacturacion.Fecha.ToString("dd-MM-yyyy") + " - " + detalle + " - " + aux.Idfacturacion.Ptoventa + "/" + aux.Idfacturacion.Numerofact;
                            if (aux.Tipocomp == 1)
                            {
                                saldo = saldo + aux.Importe;
                                dataGridView1.Rows[x].Cells[2].Value = aux.Importe;
                                dataGridView1.Rows[x].Cells[3].Value = aux.Cancelado;
                            }
                            else
                            {
                                saldo = saldo - aux.Importe;
                                dataGridView1.Rows[x].Cells[1].Value = 0.00;
                                dataGridView1.Rows[x].Cells[2].Value = aux.Importe;
                            }
                            dataGridView1.Rows[x].Cells[4].Value = "0.00";
                            x++;
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
