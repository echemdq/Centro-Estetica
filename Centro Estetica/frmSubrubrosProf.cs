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
    public partial class frmSubrubrosProf : Form
    {
        ControladoraRubros crub = new ControladoraRubros();
        ControladoraSubrubros csrub = new ControladoraSubrubros();
        ControladoraSubrubrosProf csrubpr = new ControladoraSubrubrosProf();
        string idprofe = "";
        public frmSubrubrosProf(string idprof)
        {
            InitializeComponent();
            idprofe = idprof;
        }

        private void frmSubrubrosProf_Load(object sender, EventArgs e)
        {
            List<Rubros> laux = null;
            laux = crub.TraerTodos();
            if (laux.Count != 0)
            {
                cmbRubros.DataSource = laux;
                cmbRubros.DisplayMember = "rubro";
                cmbRubros.ValueMember = "idrubros";
                cmbRubros.SelectedIndex = 0;
                cmbRubros_SelectedIndexChanged(sender, e);
            }
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "idsubrubrosprofesionales";
            dataGridView1.Columns[1].Name = "Rubro";
            dataGridView1.Columns[2].Name = "Subrubro";
            dataGridView1.Columns[0].Visible = false;
        }

        private void cmbRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rubro = cmbRubros.SelectedValue.ToString();
            List<Subrubros> laux = null;
            laux = csrub.BuscarEspecial(rubro);
            if (laux.Count != 0)
            {
                cmbSubrubros.DataSource = laux;
                cmbSubrubros.DisplayMember = "detalle";
                cmbSubrubros.ValueMember = "idsubrubros";
                cmbSubrubros.SelectedIndex = 0;
            }
            else
            {

                cmbSubrubros.DataSource = null;
                cmbSubrubros.Refresh();
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubrubros.SelectedValue.ToString() != "")
                {
                    Subrubros s = new Subrubros(Convert.ToInt32(cmbSubrubros.SelectedValue),"");
                    Profesionales p = new Profesionales(Convert.ToInt32(idprofe), "","",null,"","","",0);
                    SubrubrosProfesionales dato = new SubrubrosProfesionales(0, s, p);
                    csrubpr.Agregar(dato);
                    frmSubrubrosProf_Activated(sender, e);

                }
                else
                {
                    MessageBox.Show("Debe haber seleccionado un subrubro para agregar al profesional");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSubrubrosProf_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<SubrubrosProfesionales> a = csrubpr.BuscarEspecial(idprofe);
            int i = 0;
            foreach (SubrubrosProfesionales aux in a)
            {
                i++;
            }
            int x = 0;
            if (i > 0)
            {
                dataGridView1.Rows.Add(i);
                foreach (SubrubrosProfesionales aux in a)
                {
                    dataGridView1.Rows[x].Cells[0].Value = aux.Idsubprof;
                    dataGridView1.Rows[x].Cells[1].Value = aux.Subrubro.Rubro.Rubro;
                    dataGridView1.Rows[x].Cells[2].Value = aux.Subrubro.Detalle;
                    x++;
                }
            }

        }
    }
}
