﻿using System;
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
        int ro = 0; int col = 0;
        public frmTurnero()
        {
            InitializeComponent();
        }

        private void frmTurnero_Load(object sender, EventArgs e)
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
                DataTable dt = oacceso.leerDatos("call sp_protrabaja('" + DateTime.Today.ToString("yyyy-MM-dd") + "')");
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
                    string ingreso = Convert.ToString(dr["horario"]).Substring(0, 5);
                    string egreso = Convert.ToString(dr["horario"]).Substring(5, 5);
                    h = new HorariosProfesionales(0, p, Convert.ToString(dr["horario"]).Substring(0, 5), Convert.ToString(dr["horario"]).Substring(5, 5),DateTime.Now,"","","","","","","","");
                    dataGridView1.Columns[x].Name = p.Profesional;
                    foreach (DataGridViewRow dg in dataGridView1.Rows)
                    {
                        if (Convert.ToDateTime(dg.Cells[0].Value) >= Convert.ToDateTime(h.Ingreso) && Convert.ToDateTime(dg.Cells[0].Value) <= Convert.ToDateTime(h.Egreso))
                        {
                            int i = dataGridView1.Rows.IndexOf(dg);
                            this.dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.White;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridView1.Rows.Clear();
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
                string ingreso = Convert.ToString(dr["horario"]).Substring(0, 5);
                string egreso = Convert.ToString(dr["horario"]).Substring(5, 5);
                h = new HorariosProfesionales(0, p, Convert.ToString(dr["horario"]).Substring(0, 5), Convert.ToString(dr["horario"]).Substring(5, 5), DateTime.Now, "", "", "", "", "", "", "", "");
                dataGridView1.Columns[x].Name = p.Profesional;
                foreach (DataGridViewRow dg in dataGridView1.Rows)
                {
                    if (Convert.ToDateTime(dg.Cells[0].Value) >= Convert.ToDateTime(h.Ingreso) && Convert.ToDateTime(dg.Cells[0].Value) <= Convert.ToDateTime(h.Egreso))
                    {
                        int i = dataGridView1.Rows.IndexOf(dg);
                        this.dataGridView1.Rows[i].Cells[x].Style.BackColor = Color.White;
                    }
                }
                x++;
            }
        }

        private void nuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.White)
                {
                    frmNuevoTurno frm = new frmNuevoTurno(monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"),dataGridView1.Rows[ro].Cells[0].Value.ToString(), dataGridView1.Columns[col].Name.ToString());
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
    }
}
