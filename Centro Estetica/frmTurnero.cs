using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Centro_Estetica
{
    public partial class frmTurnero : Form
    {
        ControladoraProfesionales controlp = new ControladoraProfesionales();
        ControladoraSeguimientos controls = new ControladoraSeguimientos();
        Acceso_BD oacceso = new Acceso_BD();
        ControladoraEsperas controle = new ControladoraEsperas();
        List<grilla> laux = null;
        grilla gri;
        int ro = 0; int col = 0;
        public frmTurnero()
        {
            InitializeComponent();
        }

        private void frmTurnero_Load(object sender, EventArgs e)
        {      
            dataGridView2.DataSource = controle.BuscarEspecial(DateTime.Now.ToString("yyyy-MM-dd"));
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            label6.Text = "Dia Seleccionado: "+monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy");
            cargagrilla();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label6.Text = "Dia Seleccionado: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy");
            dataGridView1.Rows.Clear();
            cargagrilla();
        }


        public void cargagrilla()
        {
            try
            {
                laux = new List<grilla>();
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
                dataGridView1.Columns[0].Frozen = true;
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
                    Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 1,0,0);
                    int cantidad = Convert.ToInt32(Convert.ToString(dr["horario"]).Substring(Convert.ToString(dr["horario"]).Length - 1, 1));
                    string query = Convert.ToString(dr["horario"]);
                    if (Convert.ToString(dr["horasmanuales"]) != "")
                    {
                        int canthorasmanuales = 0;
                        canthorasmanuales = Convert.ToInt32(Convert.ToString(dr["horasmanuales"]).Substring(Convert.ToString(dr["horasmanuales"]).LastIndexOf(';') + 1, Convert.ToString(dr["horasmanuales"]).Length - (Convert.ToString(dr["horasmanuales"]).LastIndexOf(';') + 1)));
                        cantidad = cantidad + canthorasmanuales;
                        query = query.Substring(0,query.Length - 1);
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

                int semana = 0;
                DateTime a = monthCalendar1.SelectionRange.Start;
                CultureInfo myCI = new CultureInfo("en-US");
                CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
                Calendar myCal = myCI.Calendar;
                if (myCal.GetWeekOfYear(a, myCWR, myFirstDOW) % 2 == 0)
                {
                    semana = 2;
                }
                else
                {
                    semana = 1;
                }
                dt = oacceso.leerDatos("call sp_turnos('" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + Convert.ToInt32(monthCalendar1.SelectionRange.Start.DayOfWeek) + "','" + semana + "')");
                int col = 0;
                int idp = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]),"","",null,"","","",0,0,0);
                    if (idp != p.Idprofesionales)
                    {
                        foreach (grilla aux in laux)
                        {
                            if (-1 == aux.Fila && aux.Id == p.Idprofesionales.ToString())
                            {
                                col = aux.Columna;
                                idp = p.Idprofesionales;
                                break;
                            }
                        }
                    }
                    int fila = Convert.ToInt32(Convert.ToString(dr["hora"]).Substring(0, 2))-8;                    
                    string fijo = Convert.ToString(dr["fijo"]);
                    int asistencia = Convert.ToInt32(Convert.ToString(dr["asistencia"]));

                    if (col != 0)
                    {
                        if (asistencia == 1)
                        {
                            grilla gri = new grilla(col, fila, Convert.ToString(dr["idturnos"]));
                            laux.Add(gri);
                            this.dataGridView1.Rows[fila].Cells[col].Style.BackColor = Color.Orange;
                            this.dataGridView1.Rows[fila].Cells[col].Value = Convert.ToString(dr["detalle"]) + " " + Convert.ToString(dr["sesion"]);
                        }
                        else
                        {
                            if (fijo == "s")
                            {
                                if (Convert.ToDateTime(dr["fecha"]) == monthCalendar1.SelectionRange.Start)
                                {
                                    grilla gri = new grilla(col, fila, Convert.ToString(dr["idturnos"]));
                                    laux.Add(gri);
                                }
                                else
                                {
                                    grilla gri = new grilla(col, fila, Convert.ToString(dr["idturnos"]));
                                    laux.Add(gri);
                                }
                                if (Convert.ToString(dr["suspendido"]) == "0")
                                {
                                    this.dataGridView1.Rows[fila].Cells[col].Style.BackColor = Color.IndianRed;
                                    this.dataGridView1.Rows[fila].Cells[col].Value = Convert.ToString(dr["detalle"]) + " " + Convert.ToString(dr["sesion"]);
                                }
                                else if (this.dataGridView1.Rows[fila].Cells[col].Style.BackColor != Color.Gray)
                                {
                                    this.dataGridView1.Rows[fila].Cells[col].Style.BackColor = Color.LightBlue;
                                }
                            }
                            else if (fijo == "q")
                            {
                                if (Convert.ToDateTime(dr["fecha"]) == monthCalendar1.SelectionRange.Start)
                                {
                                    grilla gri = new grilla(col, fila, Convert.ToString(dr["idturnos"]));
                                    laux.Add(gri);
                                }
                                else
                                {
                                    grilla gri = new grilla(col, fila, Convert.ToString(dr["idturnos"]));
                                    laux.Add(gri);
                                }
                                if (Convert.ToString(dr["suspendido"]) == "0")
                                {
                                    this.dataGridView1.Rows[fila].Cells[col].Style.BackColor = Color.CornflowerBlue;
                                    this.dataGridView1.Rows[fila].Cells[col].Value = Convert.ToString(dr["detalle"]) + " " + Convert.ToString(dr["sesion"]);
                                }
                                else if (this.dataGridView1.Rows[fila].Cells[col].Style.BackColor != Color.Gray)
                                {
                                    this.dataGridView1.Rows[fila].Cells[col].Style.BackColor = Color.LightBlue;
                                }
                            }
                            else
                            {
                                grilla gri = new grilla(col, fila, Convert.ToString(dr["idturnos"]));
                                laux.Add(gri);
                                this.dataGridView1.Rows[fila].Cells[col].Style.BackColor = Color.Green;
                                this.dataGridView1.Rows[fila].Cells[col].Value = Convert.ToString(dr["detalle"]) + " " + Convert.ToString(dr["sesion"]);
                            }
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR: existen turnos para profesionales sin grilla horaria");
                    }
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
                if (monthCalendar1.SelectionRange.Start.Date >= DateTime.Now.Date)
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
                        frmNuevoTurno frm = new frmNuevoTurno(monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"), dataGridView1.Rows[ro].Cells[0].Value.ToString(), idprofesional,0);
                        frm.ShowDialog();
                    }
                    else if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.LightBlue)
                    {
                        int idprofesional = 0;
                        foreach (grilla aux in laux)
                        {
                            if (-1 == aux.Fila && col == aux.Columna)
                            {
                                idprofesional = Convert.ToInt32(aux.Id);
                            }
                        }
                        frmNuevoTurno frm = new frmNuevoTurno(monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"), dataGridView1.Rows[ro].Cells[0].Value.ToString(), idprofesional, 1);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Imposible modificar datos anteriores");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.Rows.Clear();
                cargagrilla();
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

        private void habilitaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (monthCalendar1.SelectionRange.Start.Date >= DateTime.Now.Date)
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
                            oacceso.ActualizarBD("insert into horasmanuales (idprofesionales, dia, hora, estado) values ('" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','1')");
                            oacceso.ActualizarBD("insert into seguimientos (idprofesionales, dia, hora, detalle, idturnos, fechareal, idusuarios) values ( '" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','Habilitacion Manual de Horario','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','0')");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Imposible modificar datos anteriores");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.Rows.Clear();
                cargagrilla();
            }
        }

        private void deshabilitaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (monthCalendar1.SelectionRange.Start.Date >= DateTime.Now.Date)
                {
                    if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.White || dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.LightBlue)
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
                            oacceso.ActualizarBD("insert into seguimientos (idprofesionales, dia, hora, detalle, idturnos, fechareal, idusuarios) values ( '" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','Deshabilitacion Manual de Horario','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','0')");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Imposible modificar datos anteriores");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.Rows.Clear();
                cargagrilla();
            }
        }

        private void seguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Seguimientos> lista = new List<Seguimientos>();
                int idprofesional = 0;
                foreach (grilla aux in laux)
                {
                    if (-1 == aux.Fila && col == aux.Columna)
                    {
                        idprofesional = Convert.ToInt32(aux.Id);
                    }
                }
                lista = controls.BuscarEspecial("where hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "' and dia = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and s.idprofesionales = '" + idprofesional + "' order by idseguimientos desc");
                if (lista.Count > 0)
                {
                    Profesionales p = controlp.Buscar(idprofesional.ToString());
                    frmSeguimiento frm = new frmSeguimiento(lista, p, dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5), monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy"));
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void suspenderTurnoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (monthCalendar1.SelectionRange.Start.Date >= DateTime.Now.Date)
                    {
                        if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.CornflowerBlue || dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.IndianRed)
                        {
                            DialogResult dialogResult = MessageBox.Show("Esta seguro de suspender turno dado a la hora: " + dataGridView1.Rows[ro].Cells[0].Value + " del dia: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy") + " del profesional: " + dataGridView1.Columns[col].Name.ToString(), "Suspender turno", MessageBoxButtons.YesNo);
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
                                DataTable dt = oacceso.leerDatos("select ifnull(idserviciosturnos,0) as idservt, ifnull(idservicios,0) as idserv from serviciosturnos where idprofesionales = '" + idprofesional + "' and fecha = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "'");
                                string idservt = "";
                                string idserv = "";
                                foreach (DataRow dr in dt.Rows)
                                {
                                    idservt = Convert.ToString(dr["idservt"]);
                                    idserv = Convert.ToString(dr["idserv"]);
                                }
                                dt = oacceso.leerDatos("select ifnull(idturnos,0) as id from turnos where hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "' and fecha = '" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "' and idprofesionales = '"+idprofesional+"'");
                                int idturnos = 0;
                                foreach (DataRow dr in dt.Rows)
                                {
                                    idturnos = Convert.ToInt32(dr["id"]);
                                }
                                if (idturnos == 0)
                                {
                                    oacceso.ActualizarBD("begin; delete from serviciosturnos where idserviciosturnos = '" + idservt + "'; update servicios set usadas = usadas - 1 where idservicios = '" + idserv + "'; insert into turnosuspendidos (idprofesionales, dia, hora) values ('" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "'); commit;");
                                    oacceso.ActualizarBD("insert into seguimientos (idprofesionales, dia, hora, detalle, idturnos, fechareal, idusuarios) values ( '" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','Suspende turno fijo por el dia del Cliente: " + dataGridView1.Rows[ro].Cells[col].Value.ToString() + "','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','0')");
                                    MessageBox.Show("Turno Fijo Suspendido Correctamente");
                                }
                                else
                                {
                                    MessageBox.Show("El turno comienza en el dia que desea suspender, Libere Turno");
                                }
                                dataGridView1.Rows.Clear();
                                cargagrilla();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imposible modificar datos anteriores");
                    }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void liberaTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (monthCalendar1.SelectionRange.Start.Date >= DateTime.Now.Date)
                {
                    if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.Green)
                    {
                        DialogResult dialogResult = MessageBox.Show("Esta seguro de suspender turno dado a la hora: " + dataGridView1.Rows[ro].Cells[0].Value + " del dia: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy") + " del profesional: " + dataGridView1.Columns[col].Name.ToString(), "Suspender turno", MessageBoxButtons.YesNo);
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
                            int idturnos = 0;
                            foreach (grilla aux in laux)
                            {
                                if (aux.Columna == col && aux.Fila == ro)
                                {
                                    idturnos = Convert.ToInt32(aux.Id);
                                }
                            }
                            DataTable dt = oacceso.leerDatos("select ifnull(idserviciosturnos,0) as idservt, ifnull(idservicios,0) as idserv from serviciosturnos where idprofesionales = '" + idprofesional + "' and fecha = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "'");
                            string idservt = "";
                            string idserv="";
                            foreach (DataRow dr in dt.Rows)
                            {
                                idservt = Convert.ToString(dr["idservt"]);
                                idserv = Convert.ToString(dr["idserv"]);
                            }
                            oacceso.ActualizarBD("begin; delete from serviciosturnos where idserviciosturnos = '"+idservt+"'; update servicios set usadas = usadas - 1 where idservicios = '"+idserv+"'; delete from turnos where idturnos ='"+idturnos+"'; commit;");
                            oacceso.ActualizarBD("insert into seguimientos (idprofesionales, dia, hora, detalle, idturnos, fechareal, idusuarios) values ( '" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','Libera turno del cliente: " + dataGridView1.Rows[ro].Cells[col].Value.ToString() + "','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','0')");
                            MessageBox.Show("Turno liberado Correctamente");
                            dataGridView1.Rows.Clear();
                            cargagrilla();
                        }
                    }
                    else if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.CornflowerBlue || dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.IndianRed)
                    {
                        DialogResult dialogResult = MessageBox.Show("Esta seguro de suspender turno dado a la hora: " + dataGridView1.Rows[ro].Cells[0].Value + " del dia: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy") + " del profesional: " + dataGridView1.Columns[col].Name.ToString(), "Suspender turno", MessageBoxButtons.YesNo);
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
                            int idturnos = 0;
                            DataTable dt = oacceso.leerDatos("select ifnull(idturnos,0) as id, idprofesionales as idpr, idpacientes as idpa from turnos where hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "' and fecha = '" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "' and idprofesionales = '"+idprofesional+"'");
                            int idpacientes = 0;
                            int idprof = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                idturnos = Convert.ToInt32(dr["id"]);
                                idprof = Convert.ToInt32(dr["idpr"]);
                                idpacientes = Convert.ToInt32(dr["idpa"]);
                            }
                            if (idturnos != 0)
                            {
                                dt = oacceso.leerDatos("select count(*) as ts from serviciosturnos where idpacientes = '" + idpacientes + "' and idprofesionales = '" + idprof + "' and hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "' and dayofweek(fecha) = dayofweek('" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "') and fecha >= '" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "'");
                                int ts = 0;
                                foreach (DataRow dr in dt.Rows)
                                {
                                    ts = Convert.ToInt32(dr["ts"]);
                                }
                                if (ts == 0)
                                {
                                    oacceso.ActualizarBD("begin; delete from turnos where idturnos ='" + idturnos + "'; commit;");
                                    oacceso.ActualizarBD("insert into seguimientos (idprofesionales, dia, hora, detalle, idturnos, fechareal, idusuarios) values ( '" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','Libera turno del cliente: " + dataGridView1.Rows[ro].Cells[col].Value.ToString() + "','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','0')");
                                    MessageBox.Show("Turno liberado Correctamente");
                                    dataGridView1.Rows.Clear();
                                    cargagrilla();
                                }
                                else
                                {
                                    MessageBox.Show("Turnos posteriores con servicios asignados, imposible liberar");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Utilice suspender turno, opcion valida solo para comienzos de turnos");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Imposible modificar datos anteriores");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFactura frm = new frmFactura();
            frm.ShowDialog();
        }

        private void asignarGabineteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (monthCalendar1.SelectionRange.Start == DateTime.Now.Date)
                {
                    int idprofesional = 0;
                    foreach (grilla aux in laux)
                    {
                        if (-1 == aux.Fila && col == aux.Columna)
                        {
                            idprofesional = Convert.ToInt32(aux.Id);
                        }
                    }
                    string prof = dataGridView1.Columns[col].Name.ToString();
                    frmGabinete frmq = new frmGabinete(idprofesional, prof);
                    frmq.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.Rows.Clear();
                cargagrilla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEsperas frm = new frmEsperas();
            frm.ShowDialog();
            dataGridView2.DataSource = controle.BuscarEspecial(DateTime.Now.ToString("yyyy-MM-dd"));
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[0].Visible = false;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int filaseleccionada = Convert.ToInt32(this.dataGridView2.CurrentRow.Index);
                int idsubprof = Convert.ToInt32(dataGridView2[4, filaseleccionada].Value);
                Esperas n = new Esperas(idsubprof, "", "", "");
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar", "Eliminar Espera", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controle.Borrar(n);
                    dataGridView2.DataSource = controle.BuscarEspecial(DateTime.Now.ToString("yyyy-MM-dd"));
                    dataGridView2.Columns[4].Visible = false;
                    dataGridView2.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.White && dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.Gray && dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.LightBlue)
                {
                    int idturnos = 0;
                    foreach (grilla aux in laux)
                    {
                        if (ro == aux.Fila && col == aux.Columna)
                        {
                            idturnos = Convert.ToInt32(aux.Id);
                        }
                    }
                    frmDatosTurno frm = new frmDatosTurno(idturnos, dataGridView1.Rows[ro].Cells[col].Value.ToString(), monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy"));
                    frm.ShowDialog();
                    dataGridView1.Rows.Clear();
                    cargagrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHistCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmHistorialCliente frm = new frmHistorialCliente();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void liberaInasistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.Orange && dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.White && dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.Gray && dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.LightBlue && monthCalendar1.SelectionRange.Start < DateTime.Now.Date && monthCalendar1.SelectionRange.Start >= DateTime.Now.Date.AddDays(-10))
                {
                    int idprofesional = 0;
                    foreach (grilla aux in laux)
                    {
                        if (-1 == aux.Fila && col == aux.Columna)
                        {
                            idprofesional = Convert.ToInt32(aux.Id);
                        }
                    }

                    DataTable dt = oacceso.leerDatos("select ifnull(estado,0) as estado, idservicios, idserviciosturnos from serviciosturnos where idprofesionales = '" + idprofesional + "' and hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "' and fecha = '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "'");
                    int estado = 0;
                    string idservicios = "";
                    string idserviciosturnos = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        estado = Convert.ToInt32(dr["estado"]);
                        idservicios = Convert.ToString(dr["idservicios"]);
                        idserviciosturnos = Convert.ToString(dr["idserviciosturnos"]);
                    }
                    if (estado == 0)
                    {
                        oacceso.ActualizarBD("begin; update serviciosturnos set estado = 1 where idserviciosturnos = '" + idserviciosturnos + "'; update servicios set usadas = usadas - 1 where idservicios = '" + idservicios + "'; insert into seguimientos (idprofesionales, dia, hora, detalle, idturnos, fechareal, idusuarios) values ( '" + idprofesional + "','" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "','" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "','Liberacion de inasistencia y reasignacion de sesiones','0','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','0'); commit;");
                        MessageBox.Show("Sesion de inasistencia Liberada");
                    }
                    else
                    {
                        MessageBox.Show("Servicio ya reasignado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void finTurnoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.CornflowerBlue || dataGridView1.Rows[ro].Cells[col].Style.BackColor == Color.IndianRed)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de dar por finalizado el turno a partir del dia seleccionado?", "Fin de Turno", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        int idturnos = 0;
                        foreach (grilla aux in laux)
                        {
                            if (aux.Columna == col && aux.Fila == ro)
                            {
                                idturnos = Convert.ToInt32(aux.Id);
                            }
                        }
                        DataTable dt = new DataTable();
                        int idpacientes = 0;
                        int idprofesionales = 0;
                        DateTime fin = DateTime.Now;
                        dt = oacceso.leerDatos("select idpacientes, idprofesionales, idturnos, finturnofijo from turnos where idturnos = '" + idturnos + "' and finturnofijo = '1900-01-01'");
                        foreach (DataRow dr in dt.Rows)
                        {
                            idpacientes = Convert.ToInt32(dr["idpacientes"]);
                            idprofesionales = Convert.ToInt32(dr["idprofesionales"]);
                            fin = Convert.ToDateTime(dr["finturnofijo"]);
                        }
                        if (idpacientes != 0 && idprofesionales != 0)
                        {
                            dt = oacceso.leerDatos("select count(*) as ts from serviciosturnos where idpacientes = '" + idpacientes + "' and idprofesionales = '" + idprofesionales + "' and hora = '" + dataGridView1.Rows[ro].Cells[0].Value.ToString().Substring(0, 5) + "' and dayofweek(fecha) = dayofweek('" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "') and fecha >= '" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "'");
                            int ts = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                ts = Convert.ToInt32(dr["ts"]);
                            }
                            if (ts == 0)
                            {
                                oacceso.ActualizarBD("update turnos set finturnofijo = '" + monthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM-dd") + "' where idturnos = '" + idturnos + "'");
                                MessageBox.Show("Turno finalizado correctamente");
                                dataGridView1.Rows.Clear();
                                cargagrilla();
                            }
                            else
                            {
                                MessageBox.Show("Turnos posteriores a la finalizacion con servicios asignados, imposible liberar");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El turno ya posee fecha de finalizacion");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTurnero_Activated(object sender, EventArgs e)
        {
            label6.Text = "Dia Seleccionado: " + monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy");
            dataGridView1.Rows.Clear();
            cargagrilla();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            float fontSize = dataGridView1.DefaultCellStyle.Font.Size;
            

            if (e.KeyCode == Keys.Add)//Control with '+'
            {
                dataGridView1.DefaultCellStyle.Font = new Font("Arial", fontSize + 1, FontStyle.Regular);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", fontSize + 1, FontStyle.Regular);
                foreach(DataGridViewColumn aux in dataGridView1.Columns)
                {
                    aux.Width = aux.Width + 15;
                }

            }
            else if (e.KeyCode == Keys.Subtract)//Control with '-'
            {
                dataGridView1.DefaultCellStyle.Font = new Font("Arial", fontSize - 1, FontStyle.Regular);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", fontSize - 1, FontStyle.Regular);
                foreach (DataGridViewColumn aux in dataGridView1.Columns)
                {
                    aux.Width = aux.Width - 15;
                }
            }
        }
    }
}
