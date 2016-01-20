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
    public partial class frmBuscaServicio : Form
    {
        ControladoraServicios controls = new ControladoraServicios();
        public Servicios u = null;
        string idpacientes = "";
        public frmBuscaServicio(string id)
        {
            InitializeComponent();
            idpacientes = id;
        }

        private void frmBuscaServicio_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "idservicios";
            dataGridView1.Columns[1].Name = "idproductos";
            dataGridView1.Columns[2].Name = "Detalle";
            dataGridView1.Columns[3].Name = "Sesiones";
            dataGridView1.Columns[4].Name = "Usadas";
            dataGridView1.Columns[5].Name = "idfacturacion";
            dataGridView1.Columns[6].Name = "idpacientes";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            List<Servicios> lista = controls.BuscarEspecial(idpacientes);
            int i = lista.Count;
            int x = 0;
            if (i > 0)
            {
                dataGridView1.Rows.Add(i);
                foreach (Servicios aux in lista)
                {
                    dataGridView1.Rows[x].Cells[0].Value = aux.Idservicios;
                    dataGridView1.Rows[x].Cells[1].Value = aux.Idproductos;
                    dataGridView1.Rows[x].Cells[2].Value = aux.Detalle;
                    dataGridView1.Rows[x].Cells[3].Value = aux.Sesiones;
                    dataGridView1.Rows[x].Cells[4].Value = aux.Usadas;
                    dataGridView1.Rows[x].Cells[5].Value = aux.Idfacturacion;
                    dataGridView1.Rows[x].Cells[6].Value = aux.Idpacientes;
                    x++;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
            int idservicios = Convert.ToInt32(dataGridView1[0, filaseleccionada].Value);
            int idproductos = Convert.ToInt32(dataGridView1[1, filaseleccionada].Value);
            string detalle = dataGridView1[2, filaseleccionada].Value.ToString();
            int sesiones = Convert.ToInt32(dataGridView1[3, filaseleccionada].Value);
            int usadas = Convert.ToInt32(dataGridView1[4, filaseleccionada].Value);
            int idfacturacion = Convert.ToInt32(dataGridView1[5, filaseleccionada].Value);
            int idpacientes = Convert.ToInt32(dataGridView1[6, filaseleccionada].Value);
            u = new Servicios(idservicios, idproductos, detalle, sesiones, usadas, idfacturacion, idpacientes);
            this.Close();
        }
    }
}
