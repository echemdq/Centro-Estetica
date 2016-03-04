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
    public partial class frmTurneroSalon : Form
    {
        List<grilla> laux;
        DateTime inicio;
        DateTime fin;
        int ro = 0; int col = 0;
        public frmTurneroSalon()
        {
            inicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            fin = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            InitializeComponent();
        }

        private void frmTurneroSalon_Load(object sender, EventArgs e)
        {
            
            cargagrilla();
        }


        public void cargagrilla()
        {
            try
            {
                while (fin.DayOfWeek != DayOfWeek.Sunday)
                {
                    fin = fin.AddDays(1);
                }
                while (inicio.DayOfWeek != DayOfWeek.Monday)
                {
                    inicio = inicio.AddDays(-1);
                }
                maskedTextBox1.Text = inicio.ToString("dd/MM/yyyy");
                maskedTextBox2.Text = fin.ToString("dd/MM/yyyy");
                dataGridView1.Columns.Clear();
                // Create an unbound DataGridView by declaring a column count.
                dataGridView1.ColumnCount = 8;
                dataGridView1.ColumnHeadersVisible = true;
                // Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                dataGridView1.GridColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
                // Set the column header names.
                dataGridView1.Columns[0].Name = "Horas";
                dataGridView1.Columns[1].Name = "Lunes";
                dataGridView1.Columns[2].Name = "Martes";
                dataGridView1.Columns[3].Name = "Miercoles";
                dataGridView1.Columns[4].Name = "Jueves";
                dataGridView1.Columns[5].Name = "Viernes";
                dataGridView1.Columns[6].Name = "Sabado";
                dataGridView1.Columns[7].Name = "Domingo";
                DateTime start = DateTime.Parse("08:00:00");
                DateTime start1 = DateTime.Parse("08:00:00");
                DateTime end = DateTime.Parse("22:00:00");
                while (start <= end)
                {
                    dataGridView1.Rows.Add(start.TimeOfDay.ToString());
                    start1 = start.AddMinutes(60);
                    start = start1;
                }
                laux = new List<grilla>();
                Acceso_BD oacceso = new Acceso_BD();
                DataTable dt = oacceso.leerDatos("select * from turnossalon where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'");               
                foreach (DataRow dr in dt.Rows)
                {
                    int dia = Convert.ToInt32(dr["dia"]);
                    int fila = Convert.ToInt32(Convert.ToString(dr["ingreso"]).Substring(0, 2)) - 8;
                    int filafin = fila + Convert.ToInt32(dr["cantidad"]);
                    for (int ini = fila; ini < filafin; ini++)
                    {
                        grilla gri = new grilla(dia, ini, Convert.ToString(dr["idturnossalon"]));
                        laux.Add(gri);
                        if (Convert.ToInt32(dr["pago"]) == 0)
                        {
                            this.dataGridView1.Rows[ini].Cells[dia].Style.BackColor = Color.Aquamarine;
                        }
                        else
                        {
                            this.dataGridView1.Rows[ini].Cells[dia].Style.BackColor = Color.DarkTurquoise;
                        }
                        this.dataGridView1.Rows[ini].Cells[dia].Value = Convert.ToString(dr["nombre"]).ToUpper();
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridView1.Rows.Clear();
            cargagrilla();
        }

        private void nuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = col.ToString();
                DateTime fechaturno = inicio.AddDays(Convert.ToDouble(dia) - 1);
                if (fechaturno >= DateTime.Now.Date)
                {
                    if (dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.Aquamarine)
                    {   
                        frmNuevoTurnoSalon frm = new frmNuevoTurnoSalon(fechaturno.ToString("dd/MM/yyyy"), col, dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5));
                        frm.ShowDialog();
                        dataGridView1.Columns.Clear();
                        cargagrilla();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                var ht = dataGridView1.HitTest(e.X, e.Y);
                //Checks for correct column index
                ro = ht.RowIndex;
                col = ht.ColumnIndex;
            }
        }

        private void datosTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.Aquamarine)
                {
                    int idturnos = 0;
                    foreach (grilla aux in laux)
                    {
                        if (ro == aux.Fila && col == aux.Columna)
                        {
                            idturnos = Convert.ToInt32(aux.Id);
                        }
                    }
                    frmDatosTurnoSalon frm = new frmDatosTurnoSalon(idturnos);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminaTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.Aquamarine)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el turno", "Eliminar Turno", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idturnos = 0;
                        foreach (grilla aux in laux)
                        {
                            if (ro == aux.Fila && col == aux.Columna)
                            {
                                idturnos = Convert.ToInt32(aux.Id);
                            }
                        }
                        Acceso_BD oa = new Acceso_BD();
                        oa.ActualizarBD("delete from turnossalon where idturnossalon = '" + idturnos + "'");
                        MessageBox.Show("Turno eliminado correctamente");
                        dataGridView1.Columns.Clear();
                        cargagrilla();
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
            inicio = inicio.AddDays(7);
            fin = fin.AddDays(7);
            cargagrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio = inicio.AddDays(-7);
            fin = fin.AddDays(-7);
            cargagrilla();
        }

        private void pagoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.Aquamarine)
                {
                    DialogResult dialogResult = MessageBox.Show("Asignar pago al turno ?", "Pago Turno", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idturnos = 0;
                        foreach (grilla aux in laux)
                        {
                            if (ro == aux.Fila && col == aux.Columna)
                            {
                                idturnos = Convert.ToInt32(aux.Id);
                            }
                        }
                        Acceso_BD oa = new Acceso_BD();
                        oa.ActualizarBD("update turnossalon set pago = 1 where idturnossalon = '" + idturnos + "'");
                        MessageBox.Show("Pagó turno correctamente");
                        dataGridView1.Columns.Clear();
                        cargagrilla();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void anulaPagoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.DarkTurquoise)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el pago", "Eliminar Pago Turno", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idturnos = 0;
                        foreach (grilla aux in laux)
                        {
                            if (ro == aux.Fila && col == aux.Columna)
                            {
                                idturnos = Convert.ToInt32(aux.Id);
                            }
                        }
                        Acceso_BD oa = new Acceso_BD();
                        oa.ActualizarBD("update turnossalon set pago = 0 where idturnossalon = '" + idturnos + "'");
                        MessageBox.Show("Pagó Turno eliminado correctamente");
                        dataGridView1.Columns.Clear();
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
