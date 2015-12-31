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
    public partial class frmBuscaProductos : Form
    {
        ControladoraProductos controlp = new ControladoraProductos();
        public Productos u = null;
        public frmBuscaProductos()
        {
            InitializeComponent();
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text != "")
            {
                dataGridView1.Rows.Clear();
                string d1 = "";
                string d2 = "";
                string d3 = txtPaciente.Text.Trim();
                int cant = 1;

                bool a = true;
                while (a == true)
                {
                    int f = d3.LastIndexOf(" ");
                    if (f == -1 && d3.Length != 0)
                    {
                        d1 = d3.Trim();
                        d3 = "";
                        if (cant == 1)
                        {
                            d2 += " like '%" + d1 + "%' ";
                        }
                        else
                        {
                            d2 += " and profesional like '%" + d1 + "%' ";
                        }
                        a = false;
                    }
                    else
                    {
                        int c = d3.LastIndexOf(" ");

                        if (c != -1)
                        {
                            int d = d3.LastIndexOf(" ");
                            d1 = d3.Substring(d, d3.Length - d);
                            d1 = d1.Trim();
                            d = d3.LastIndexOf(" ");
                            d3 = d3.Substring(0, d);
                            if (cant == 1)
                            {
                                d2 += " like '%" + d1 + "%' ";
                            }
                            else
                            {
                                d2 += " and profesional like '%" + d1 + "%' ";

                            }
                        }
                        else
                        {
                            a = false;
                        }
                    }
                    cant++;
                }
                List<Productos> lista = controlp.BuscarEspecial(d2);
                int i = 0;
                foreach (Productos aux in lista)
                {
                    i++;
                }
                int x = 0;
                if (i > 0)
                {
                    dataGridView1.Rows.Add(i);
                    foreach (Productos aux in lista)
                    {
                        dataGridView1.Rows[x].Cells[0].Value = aux.Idproductos;
                        dataGridView1.Rows[x].Cells[1].Value = aux.Detalle;
                        dataGridView1.Rows[x].Cells[2].Value = aux.Stock;
                        dataGridView1.Rows[x].Cells[3].Value = aux.Sesiones;
                        dataGridView1.Rows[x].Cells[4].Value = aux.Precioventa;
                        dataGridView1.Rows[x].Cells[5].Value = aux.Preciocalculo;
                        dataGridView1.Rows[x].Cells[6].Value = aux.Activo;
                        x++;
                    }
                }
            }
        }

        private void frmBuscaProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "idproductos";
            dataGridView1.Columns[1].Name = "Detalle";
            dataGridView1.Columns[2].Name = "Stock";
            dataGridView1.Columns[3].Name = "Sesiones";
            dataGridView1.Columns[4].Name = "Precio Venta";
            dataGridView1.Columns[5].Name = "Precio Calculo";
            dataGridView1.Columns[6].Name = "Activo";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTraer_Click(sender, e);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
            int idproductos = Convert.ToInt32(dataGridView1[0, filaseleccionada].Value);
            string detalle = dataGridView1[1, filaseleccionada].Value.ToString();
            Decimal precioventa = Convert.ToDecimal(dataGridView1[4, filaseleccionada].Value.ToString());
            int stock = Convert.ToInt32(dataGridView1[2, filaseleccionada].Value);
            int sesiones = Convert.ToInt32(dataGridView1[3, filaseleccionada].Value);
            Decimal preciocalculo = Convert.ToDecimal(dataGridView1[5, filaseleccionada].Value.ToString());
            int activo = Convert.ToInt32(dataGridView1[6, filaseleccionada].Value);
            u = new Productos(idproductos, detalle, precioventa, sesiones, stock, activo, preciocalculo);
            this.Close();
        }
    }
}
