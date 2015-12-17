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
    public partial class frmTurnero : Form
    {
        ControladoraProfesionales controlp = new ControladoraProfesionales();
        public frmTurnero()
        {
            InitializeComponent();
        }

        private void frmTurnero_Load(object sender, EventArgs e)
        {
            try
            {
                List<Profesionales> lprof = controlp.TraerTodos();
                int cantprof = lprof.Count;
                dataGridView1.ColumnCount = cantprof + 1;
                dataGridView1.ColumnHeadersVisible = true;
                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dataGridView1.GridColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
                dataGridView1.Columns[0].Name = "Horas";
                int x = 1;
                foreach (Profesionales prof in lprof)
                {
                    dataGridView1.Columns[x].Name = prof.Profesional;
                    x++;
                }
                DateTime start = DateTime.Parse("08:00:00");
                DateTime start1 = DateTime.Parse("08:00:00");
                DateTime end = DateTime.Parse("22:00:00");
                while (start <= end)
                {
                    dataGridView1.Rows.Add(start.TimeOfDay.ToString());
                    start1 = start.AddMinutes(60);
                    start = start1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
