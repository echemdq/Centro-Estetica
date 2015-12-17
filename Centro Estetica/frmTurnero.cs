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
        Acceso_BD oacceso = new Acceso_BD();
        public frmTurnero()
        {
            InitializeComponent();
        }

        private void frmTurnero_Load(object sender, EventArgs e)
        {
            try
            {
                //List<Profesionales> lprof = controlp.TraerTodos();
                //int cantprof = lprof.Count;
                //dataGridView1.ColumnCount = cantprof + 1;
                dataGridView1.ColumnHeadersVisible = true;
                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dataGridView1.GridColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                dataGridView1.DefaultCellStyle.BackColor = Color.Beige;                
                DataTable dt = oacceso.leerDatos("call sp_protrabaja('" + DateTime.Today.ToString("yyyy-MM-dd") + "')");
                dataGridView1.ColumnCount = dt.Rows.Count + 1;
                dataGridView1.Columns[0].Name = "Horas";
                //int x = 1;
                //foreach (Profesionales prof in lprof)
                //{
                //    dataGridView1.Columns[x].Name = prof.Profesional;
                //    x++;
                //}
                DateTime start = DateTime.Parse("08:00:00");
                DateTime start1 = DateTime.Parse("08:00:00");
                DateTime end = DateTime.Parse("22:00:00");
                while (start <= end)
                {
                    dataGridView1.Rows.Add(start.TimeOfDay.ToString());
                    start1 = start.AddMinutes(60);
                    start = start1;
                }
                HorariosProfesionales h = null;
                int x = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 1);
                    string ingreso = Convert.ToString(dr["horario"]).Substring(0, 5);
                    string egreso = Convert.ToString(dr["horario"]).Substring(5, 5);
                    h = new HorariosProfesionales(0, p, Convert.ToString(dr["horario"]).Substring(0, 5), Convert.ToString(dr["horario"]).Substring(5, 5),DateTime.Now,"","","","","","","");
                    dataGridView1.Columns[x].Name = p.Profesional;
                    x++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
