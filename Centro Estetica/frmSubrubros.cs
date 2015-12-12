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
    public partial class frmSubrubros : Form
    {
        ControladoraRubros controlr = new ControladoraRubros();
        ControladoraSubrubros controlsr = new ControladoraSubrubros();
        public frmSubrubros()
        {
            InitializeComponent();
        }

        private void frmSubrubros_Load(object sender, EventArgs e)
        {
            List<Rubros> laux = null;
            laux = controlr.TraerTodos();
            if (laux.Count != 0)
            {
                cmbRubros.DataSource = laux;
                cmbRubros.DisplayMember = "rubro";
                cmbRubros.ValueMember = "idrubros";
                cmbRubros.SelectedIndex = 0;
                cmbRubros_SelectedIndexChanged(sender, e);
            }
        }

        private void cmbRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                string rubro = cmbRubros.SelectedValue.ToString();
                dataGridView1.DataSource = controlsr.BuscarEspecial(rubro);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void limpiar()
        {
            txtSubrubro.Text = "";
            txtId.Text = "";
        }
        public void habilitar()
        {
            txtSubrubro.ReadOnly = false;
            txtSubrubro.Enabled = true;
        }
        public void deshabilitar()
        {
            txtSubrubro.ReadOnly = true;
            txtSubrubro.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            habilitar();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubrubro.Text != "")
                {
                    int idrub = cmbRubros.SelectedIndex;
                    Rubros ru = new Rubros(Convert.ToInt32(cmbRubros.SelectedValue), "");
                    Subrubros r = new Subrubros(0, txtSubrubro.Text, ru);
                    if (txtId.Text == "")
                    {
                        controlsr.Agregar(r);
                        MessageBox.Show("Subrubro guardado correctamente");
                    }
                    else
                    {
                        r.Idsubrubros = Convert.ToInt32(txtId.Text);
                        controlsr.Modificar(r);
                        MessageBox.Show("Subrubro modificado correctamente");
                    }
                    limpiar();
                    deshabilitar();
                    dataGridView1.DataSource = controlsr.BuscarEspecial(cmbRubros.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Debe completar el detalle del Subrubro");
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
                    Subrubros r = new Subrubros(Convert.ToInt32(txtId.Text), txtSubrubro.Text);
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el subrubro: "+txtSubrubro.Text, "Eliminar Subrubro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        controlsr.Borrar(r);
                        limpiar();
                        deshabilitar();
                        dataGridView1.DataSource = controlsr.BuscarEspecial(cmbRubros.SelectedValue.ToString());
                        MessageBox.Show("Subrubro eliminado correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un subrubro para eliminarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                int idsubrubros = Convert.ToInt32(dataGridView1[2, filaseleccionada].Value);
                string detalle = dataGridView1[1, filaseleccionada].Value.ToString();
                txtId.Text = idsubrubros.ToString();
                txtSubrubro.Text = detalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
