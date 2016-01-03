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
        List<grilla> laux = new List<grilla>();
        grilla gri;
        int ro = 0; int col = 0;
        public frmTurnero()
        {
            InitializeComponent();
        }

        private void frmTurnero_Load(object sender, EventArgs e)
        {
            cargagrilla();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridView1.Rows.Clear();
            cargagrilla();
        }


        public void cargagrilla()
        {
            try
            {
                dataGridView1.ColumnHeadersVisible = true;
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dataGridView1.GridColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
                DataTable dt = oacceso.leerDatos("call sp_protrabaja('" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "')");
                dataGridView1.ColumnCount = dt.Rows.Count + 1;
                dataGridView1.Columns[0].Name = "Horario";
                DateTime start = DateTime.Parse("08:00");
                DateTime start1 = DateTime.Parse("08:00");
                DateTime end = DateTime.Parse("22:00");
                int row = 0;
                while (start <= end)
                {
                    dataGridView1.Rows.Add(start.TimeOfDay.ToString());
                    dataGridView1.Rows[row].Cells[0].Style.ForeColor = Color.White;
                    start1 = start.AddMinutes(60);
                    start = start1;
                    row++;
                }
                HorariosProfesionales h = null;
                int x = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 1);
                    int cantidad = Convert.ToInt32(Convert.ToString(dr["horario"]).Substring(Convert.ToString(dr["horario"]).Length - 1, 1));
                    string query = Convert.ToString(dr["horario"]);
                    if (Convert.ToString(dr["horasmanuales"]) != "")
                    {
                        cantidad = cantidad + Convert.ToInt32(Convert.ToString(dr["horasmanuales"]).Substring(Convert.ToString(dr["horasmanuales"]).Length - 1, 1));
                        query = query + Convert.ToString(dr["horasmanuales"]);
                    }
                    int desde = 0;
                    int hasta = 5;                    
                    for (int z = 1; z <= cantidad; z++)
                    {
                        string ingreso = query.Substring(desde, 5);
                        string egreso = query.Substring(hasta, 5);
                        query = query.Substring(11, query.Length - 11);
                        h = new HorariosProfesionales(0, p, ingreso, egreso, DateTime.Now, "", "", "", "", "", "", "", "");
                        dataGridView1.Columns[x].Name = p.Profesional;
                        gri = new grilla(x, -1, p.Idprofesionales.ToString());
                        laux.Add(gri);
                        foreach (DataGridViewRow dg in dataGridView1.Rows)
                        {
                            if (h.Egreso != "10000" && h.Egreso != "00000")
                            {
                                if (Convert.ToDateTime(dg.Cells[0].Value) >= Convert.ToDateTime(h.Ingreso) && Convert.ToDateTime(dg.Cells[0].Value) <= Convert.ToDateTime(h.Egreso))
                                {
                                    int i = dataGridView1.Rows.IndexOf(dg);
                                    this.dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.White;
                                }
                                else
                                {
                                    int i = dataGridView1.Rows.IndexOf(dg);
                                    if (this.dataGridView1.Rows[i].Cells[x].Style.BackColor != Color.White)
                                    {
                                        this.dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.Gray;
                                    }
                                }
                            }
                            else
                            {
                                if (Convert.ToDateTime(dg.Cells[0].Value) == Convert.ToDateTime(h.Ingreso))
                                {
                                    
                                    int i = dataGridView1.Rows.IndexOf(dg);
                                    if (h.Egreso == "10000")
                                    {
                                        this.dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        this.dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.Gray;
                                    }
                                }
                            }
                        }
                    }
                    x++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.White)
                {
                    int idprofesional = 0;
                    foreach (grilla aux in laux)
                    {
                        if (-1 == aux.Fila && col == aux.Columna)
                        {
                            idprofesional = Convert.ToInt32(aux.Id);
                        }
                    }
                    frmNuevoTurno frm = new frmNuevoTurno(monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"),dataGridView1.Rows[ro].Cells[0].Value.ToString(), idprofesional);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ht = dataGridView1.HitTest(e.X, e.Y);
                //Checks for correct column index
                ro = ht.RowIndex;
                col = ht.ColumnIndex;
            }
        }

        private void habilitaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.Gray)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de habilitar la hora: " + dataGridView1.Rows[ro].Cells[0].Value + " del dia: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy") + " del profesional: " + dataGridView1.Columns[col].Name.ToString(), "Habilitar Hora", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idprofesional = 0;
                        foreach (grilla aux in laux)
                        {
                            if (-1 == aux.Fila && col == aux.Columna)
                            {
                                idprofesional = Convert.ToInt32(aux.Id);
                            }
                        }
                        oacceso.ActualizarBD("insert into horasmanuales (idprofesionales, dia, hora, estado) values ('" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0,5) + "','1')");
                        dataGridView1.Rows.Clear();
                        cargagrilla();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deshabilitaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.White)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de deshabilitar la hora: " + dataGridView1.Rows[ro].Cells[0].Value + " del dia: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy") + " del profesional: " + dataGridView1.Columns[col].Name.ToString(), "Deshabilitar Hora", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idprofesional = 0;
                        foreach (grilla aux in laux)
                        {
                            if (-1 == aux.Fila && col == aux.Columna)
                            {
                                idprofesional = Convert.ToInt32(aux.Id);
                            }
                        }
                        oacceso.ActualizarBD("insert into horasmanuales (idprofesionales, dia, hora, estado) values ('" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','0')");
                        dataGridView1.Rows.Clear();
                        cargagrilla();
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
