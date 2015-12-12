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
    public partial class frmRubros : Form
    {
        ControladoraRubros crubros = new ControladoraRubros();
        public frmRubros()
        {
            InitializeComponent();
        }

        private void frmRubros_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = crubros.TraerTodos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                int idrubros = Convert.ToInt32(dataGridView1[1, filaseleccionada].Value);
                string detalle = dataGridView1[0, filaseleccionada].Value.ToString();
                txtId.Text = idrubros.ToString();
                txtRubro.Text = detalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void limpiar()
        {
            txtRubro.Text = "";
            txtId.Text = "";
        }
        public void habilitar()
        {
            txtRubro.ReadOnly = false;
            txtRubro.Enabled = true;
        }
        public void deshabilitar()
        {
            txtRubro.ReadOnly = true;
            txtRubro.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRubro.Text != "")
                {
                    Rubros r = new Rubros(0, txtRubro.Text);
                    if (txtId.Text == "")
                    {
                        crubros.Agregar(r);
                        MessageBox.Show("Rubro guardado correctamente");
                    }
                    else
                    {
                        r.Idrubros = Convert.ToInt32(txtId.Text);
                        crubros.Modificar(r);
                        MessageBox.Show("Rubro modificado correctamente");
                    }
                    limpiar();
                    deshabilitar();
                    dataGridView1.DataSource = crubros.TraerTodos();
                    
                }
                else
                {
                    MessageBox.Show("Debe completar el detalle del rubro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    Rubros r = new Rubros(Convert.ToInt32(txtId.Text), txtRubro.Text);
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el rubro: "+txtRubro.Text, "Eliminar Rubro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        crubros.Borrar(r);
                        limpiar();
                        deshabilitar();
                        dataGridView1.DataSource = crubros.TraerTodos();
                        MessageBox.Show("Rubro eliminado correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un rubro para eliminarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                habilitar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            deshabilitar();
        }
    }
}
