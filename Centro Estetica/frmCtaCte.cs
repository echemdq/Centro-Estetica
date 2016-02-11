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
    public partial class frmCtaCte : Form
    {
        ControladoraCtaCte c = new ControladoraCtaCte();
        Pacientes p = null;
        public frmCtaCte()
        {
            InitializeComponent();
        }

        private void frmCtaCte_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Detalle";
            dataGridView1.Columns[1].Name = "Debe";
            dataGridView1.Columns[2].Name = "Haber";
            dataGridView1.Columns[3].Name = "Saldo";
            dataGridView1.Columns[4].Name = "Cancelado";
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (p != null)
                {
                    dataGridView1.Rows.Clear();
                    List<Ctacte> lista = new List<Ctacte>();
                    lista = c.TraerTodos(p.Idpacientes.ToString());
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
                            dataGridView1.Rows[x].Cells[0].Value = aux.Idfacturacion.Fecha.ToString("dd-MM-yyyy") + " - " +detalle + " - " + aux.Idfacturacion.Ptoventa + "/" + aux.Idfacturacion.Numerofact;
                            if (aux.Tipocomp == 1)
                            {
                                saldo = saldo + aux.Importe;
                                dataGridView1.Rows[x].Cells[1].Value = aux.Importe;
                                dataGridView1.Rows[x].Cells[2].Value = 0.00;
                            }
                            else
                            {
                                saldo = saldo - aux.Importe;
                                dataGridView1.Rows[x].Cells[1].Value = 0.00;
                                dataGridView1.Rows[x].Cells[2].Value = aux.Importe;
                            }
                            dataGridView1.Rows[x].Cells[3].Value = saldo;
                            dataGridView1.Rows[x].Cells[4].Value = aux.Cancelado;
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
    }
}
