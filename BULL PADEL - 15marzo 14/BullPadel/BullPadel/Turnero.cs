using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace BullPadel
{
    public partial class Turnero : Form
    {
        List<novedades> lista = new List<novedades>();
        List<grilla> laux = new List<grilla>();
        AccesoBD oacceso = new AccesoBD();
        DateTime inicio;
        DateTime fin;
        grilla gri;
        int ro = 0; int col = 0;
        public Turnero()
        {
            inicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            fin = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            InitializeComponent();
        }

        private void manejador_de_evento_botones_generados(object sender, EventArgs e)
        {
            Button fuente = (Button)sender;
            string nro = fuente.Name;
            DialogResult dRe = new DialogResult();
            dRe = MessageBox.Show("Esta seguro de cancelar la deuda del cliente: " + fuente.Text, "Cancela Deuda", MessageBoxButtons.OKCancel);
            if (dRe == DialogResult.OK)
            {
                string cmdtext = "update turnos set deuda = 0 where idturnos = '" + fuente.Name + "'";
                oacceso.ActualizarBD(cmdtext);
                pnlContainer.Controls.Clear();
                string cmdtest = "select deuda, descripcion, idturnos from turnos t inner join clientes c on t.idcliente = c.idclientes where deuda > 0";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtest);
                foreach (DataRow dr in dt.Rows)
                {
                    Button tmpButton = new Button();
                    string nombre = Convert.ToString(dr["descripcion"]) + " " + Convert.ToString(dr["deuda"]);
                    string name = Convert.ToString(dr["idturnos"]);
                    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                    ToolTip1.SetToolTip(tmpButton, nombre);
                    tmpButton.Name = name;
                    tmpButton.Text = nombre;
                    tmpButton.Font = new Font("Verdana", 6, FontStyle.Bold);
                    tmpButton.Size = new Size(132, 23);
                    tmpButton.BackColor = Color.GreenYellow;
                    tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                    pnlContainer.Controls.Add(tmpButton);
                }
            }
        }

        private void Turnero_Load(object sender, EventArgs e)
        {            
            ///////////////////////////////////////////////////

            string cmdtest = "select deuda, descripcion, idturnos from turnos t inner join clientes c on t.idcliente = c.idclientes where deuda > 0";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtest);
            foreach (DataRow dr in dt.Rows)
            {
                Button tmpButton = new Button();
                string nombre = Convert.ToString(dr["descripcion"]) + " " + Convert.ToString(dr["deuda"]);
                string name = Convert.ToString(dr["idturnos"]);
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(tmpButton, nombre);
                tmpButton.Name = name;
                tmpButton.Text = nombre;
                tmpButton.Font = new Font("Verdana", 6, FontStyle.Bold);
                tmpButton.Size = new Size(132, 23);
                tmpButton.BackColor = Color.GreenYellow;
                tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                pnlContainer.Controls.Add(tmpButton);
            }

            ///////////////////////////////////////////////////
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
            dt = new DataTable();
            dt = oacceso.leerDatos("select hora from configuraciones where codigo = 'horaini'");
            DateTime start = DateTime.Parse("10:00:00");
            DateTime start1 = DateTime.Parse("10:00:00");
            DateTime end = DateTime.Parse("23:00:00");
            foreach (DataRow dr in dt.Rows)
            {
                start = DateTime.Parse(Convert.ToString(dr["hora"]));
                start1 = DateTime.Parse(Convert.ToString(dr["hora"]));
            }
            dt = oacceso.leerDatos("select hora from configuraciones where codigo = 'horafin'");
            foreach (DataRow dr in dt.Rows)
            {
                end = DateTime.Parse(Convert.ToString(dr["hora"]));
            }
            
            while (start <= end)
            {
                dataGridView1.Rows.Add(start.TimeOfDay.ToString());
                start1 = start.AddMinutes(30);
                start = start1;
            }
            lista.Clear();
            dt = oacceso.leerDatos("select * from novedades where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'");
            lista.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                novedades onovedades = new novedades(Convert.ToInt32(dr["idturno"]), Convert.ToString(dr["fecha"]));
                lista.Add(onovedades);
            }
            dt = oacceso.leerDatos("select * from turnos where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' or idcliente is not null");

            foreach (DataRow dr in dt.Rows)
            {
                string idt = Convert.ToString(dr["idturnos"]);
                string tipo = Convert.ToString(dr["fecha"]);
                {
                    tipo = "";
                }
                string horaini = Convert.ToString(dr["ingreso"]);
                string horafin = Convert.ToString(dr["egreso"]);
                DateTime dateValue = DateTime.Today;
                //int dia = (int) dateValue.DayOfWeek;
                int dia = Convert.ToInt32(dr["dia"]);
                string nombre = Convert.ToString(dr["nombre"]);
                string id = Convert.ToString(dr["idcliente"]);
                if (id != "")
                {
                    dt = oacceso.leerDatos("select descripcion from clientes where idclientes = '" + id + "'");
                    foreach (DataRow d1r in dt.Rows)
                    {
                        nombre = Convert.ToString(d1r["descripcion"]);
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Random randonGen = new Random();
                    Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                    randonGen.Next(255));

                    if (horaini == Convert.ToString(row.Cells[0].Value))
                    {

                        int i = dataGridView1.Rows.IndexOf(row);
                        if (tipo == "")
                        {
                            bool esta = false;
                            
                            foreach (novedades aux in lista)
                            {
                                DateTime fecha = Convert.ToDateTime(aux.Fecha);
                                if (Convert.ToInt32(idt) == aux.idTurno)
                                {
                                    if (fecha >= inicio && fecha <= fin)
                                    {
                                        esta = true;
                                    }
                                }
                            }
                            if (esta == false)
                            {
                                gri = new grilla(dia, i, idt);
                                laux.Add(gri);
                                this.dataGridView1.Rows[i].Cells[dia].Value = nombre;
                                this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Red;
                                if (this.dataGridView1.Rows[i].Cells[dia].Style.BackColor == Color.Aquamarine)
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Gold;
                                }
                                if (randomColor == Color.Black || randomColor == Color.MidnightBlue)
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Style.ForeColor = Color.White;
                                }
                            }                            
                        }
                        else
                        {
                            DateTime fecha = Convert.ToDateTime(tipo);
                            if (fecha >= inicio && fecha <= fin)
                            {
                                gri = new grilla(dia, i, idt);
                                laux.Add(gri);
                                this.dataGridView1.Rows[i].Cells[dia].Value = nombre + " " + fecha.ToString("dd/MM/yyyy");
                                this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Orange;
                            }
                        }
                        start = DateTime.Parse(horaini);
                        start1 = DateTime.Parse(horaini);
                        end = DateTime.Parse(horafin);
                        DateTime end1 = end.AddMinutes(-30);
                        while (start < end1)
                        {
                            i++;
                            if (tipo == "")
                            {
                                bool esta = false;

                                foreach (novedades aux in lista)
                                {
                                    DateTime fecha = Convert.ToDateTime(aux.Fecha);
                                    if (Convert.ToInt32(idt) == aux.idTurno)
                                    {
                                        if (fecha >= inicio && fecha <= fin)
                                        {
                                            esta = true;
                                        }
                                    }
                                }
                                if (esta == false)
                                {
                                    gri = new grilla(dia, i, idt);
                                    laux.Add(gri);
                                    this.dataGridView1.Rows[i].Cells[dia].Value = nombre;
                                    this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Red;
                                    if (this.dataGridView1.Rows[i].Cells[dia].Style.BackColor == Color.Aquamarine)
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Gold;
                                    }
                                    if (randomColor == Color.Black || randomColor == Color.MidnightBlue)
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Style.ForeColor = Color.White;
                                    }
                                } 
                            }
                            else
                            {
                                DateTime fecha = Convert.ToDateTime(tipo);
                                if (fecha >= inicio && fecha <= fin)
                                {
                                    gri = new grilla(dia, i, idt);
                                    laux.Add(gri);
                                    this.dataGridView1.Rows[i].Cells[dia].Value = nombre + " " + fecha.ToString("dd/MM/yyyy");
                                    this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Orange;

                                }
                            }
                            start1 = start.AddMinutes(30);
                            start = start1;
                        }
                        break;
                    }


                    else if (horafin == Convert.ToString(row.Cells[0].Value))
                    {
                        gri = new grilla(dia, dataGridView1.Rows.IndexOf(row) - 1, idt);
                        laux.Add(gri);
                        this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Value = nombre + " " + tipo;

                        this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.BackColor = Color.Red; 
                        if (this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.BackColor == Color.Aquamarine)
                        {
                            this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.BackColor = Color.Gold;
                        }
                        if (randomColor == Color.Black || randomColor == Color.MidnightBlue)
                        {
                            this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.ForeColor = Color.White;
                        }

                    }

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hora = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string dia = e.ColumnIndex.ToString();
            int row = e.RowIndex;
            bool suspendido = false;
            if (Convert.ToInt32(dia) > 0 && row > 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Aquamarine)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        suspendido = true;
                    }
                    else
                    {
                        suspendido = false;
                    }
                    DateTime fechaturno = inicio.AddDays(Convert.ToDouble(dia) - 1);
                    ABM_Turnos frm = new ABM_Turnos(hora, dia, fechaturno, suspendido);
                    frm.Show();                   
                }               
            }
        }

        private void Turnero_Activated(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////
            

            ///////////////////////////////////////////////////
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
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.GridColor = Color.Black;            
            // Set the column header names.
            dataGridView1.Columns[0].Name = "Horas";
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[1].Name = "Lunes";
            this.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[2].Name = "Martes";
            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[3].Name = "Miercoles";
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[4].Name = "Jueves";
            this.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[5].Name = "Viernes";
            this.dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[6].Name = "Sabado";
            this.dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridView1.Columns[7].Name = "Domingo";
            this.dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos("select hora from configuraciones where codigo = 'horaini'");
            DateTime start = DateTime.Parse("10:00:00");
            DateTime start1 = DateTime.Parse("10:00:00");
            DateTime end = DateTime.Parse("23:00:00");
            string horain = "";
            string horaf = "";
            foreach (DataRow dr in dt.Rows)
            {
                start = DateTime.Parse(Convert.ToString(dr["hora"]));
                start1 = DateTime.Parse(Convert.ToString(dr["hora"]));
                horain = Convert.ToString(dr["hora"]);
            }
            dt = oacceso.leerDatos("select hora from configuraciones where codigo = 'horafin'");
            foreach (DataRow dr in dt.Rows)
            {
                end = DateTime.Parse(Convert.ToString(dr["hora"]));
                horaf = Convert.ToString(dr["hora"]);
            }
            if (String.Compare(horain, horaf) > 0)
            {
                end = end.AddDays(1);
            }
            while (start <= end)
            {

                dataGridView1.Rows.Add(start.TimeOfDay.ToString());
                start1 = start.AddMinutes(30);
                start = start1;
            }
            dt = oacceso.leerDatos("select * from novedades where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'");
            lista.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                novedades onovedades = new novedades(Convert.ToInt32(dr["idturno"]), Convert.ToString(dr["fecha"]));
                lista.Add(onovedades);
            }
            dt = oacceso.leerDatos("select * from turnos where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' or idcliente is not null");
            foreach (DataRow dr in dt.Rows)
            {
                string idt = Convert.ToString(dr["idturnos"]);
                string tipo = Convert.ToString(dr["fecha"]);
                if (tipo == "0000-00-00")
                {
                    tipo = "";
                }
                string horaini = Convert.ToString(dr["ingreso"]);
                string horafin = Convert.ToString(dr["egreso"]);
                DateTime dateValue = DateTime.Today;
                //int dia = (int) dateValue.DayOfWeek;
                int dia = Convert.ToInt32(dr["dia"]);
                string nombre = Convert.ToString(dr["nombre"]);
                string id = Convert.ToString(dr["idcliente"]);
                if (id != "")
                {
                    dt = oacceso.leerDatos("select descripcion from clientes where idclientes = '" + id + "'");
                    foreach (DataRow d1r in dt.Rows)
                    {
                        nombre = Convert.ToString(d1r["descripcion"]);
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int ix = 0;
                    Random randonGen = new Random();
                    Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                    randonGen.Next(255));
                    if (horaini == Convert.ToString(row.Cells[0].Value))
                    {

                        int i = dataGridView1.Rows.IndexOf(row);
                        if (tipo == "")
                        {
                            bool esta = false;

                            foreach (novedades aux in lista)
                            {
                                DateTime fecha = Convert.ToDateTime(aux.Fecha);
                                if (Convert.ToInt32(idt) == aux.idTurno)
                                {
                                    if (fecha >= inicio && fecha <= fin)
                                    {
                                        dt = oacceso.leerDatos("select 'hay turno' as ok, nombre from turnos where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' and idcliente is not null");
                                        bool ok = true;
                                        string n =""; 
                                        foreach (DataRow d2r in dt.Rows)
                                        {
                                            if ((Convert.ToString(d2r["ok"])) == "hay turno")
                                            {
                                                ok = false;
                                                n = Convert.ToString(d2r["nombre"]);
                                            }
                                            else ok = true;
                                        }
                                        esta = true;
                                        if (ok == true)
                                        {
                                            gri = new grilla(dia, i, idt);
                                            laux.Add(gri);
                                            this.dataGridView1.Rows[i].Cells[dia].Value = "Turno suspendido";
                                            this.dataGridView1.Rows[i].Cells[dia].Style.Font = new Font(this.Font, FontStyle.Bold);
                                            this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Aquamarine;
                                        }
                                        else
                                        {
                                            gri = new grilla(dia, i, idt);
                                            laux.Add(gri);
                                            this.dataGridView1.Rows[i].Cells[dia].Value = n + " " + fecha.ToShortDateString();
                                            this.dataGridView1.Rows[i].Cells[dia].Style.Font = new Font(this.Font, FontStyle.Bold);
                                            this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Aquamarine;
                                        }
                                    }
                                }
                            }
                            if (esta == false)
                            {
                                gri = new grilla(dia, i, idt);
                                laux.Add(gri);
                                if (ix > 0)
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Value = "X";
                                }
                                else
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Value = nombre;
                                    ix++;
                                }
                                this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Red; 
                                if (this.dataGridView1.Rows[i].Cells[dia].Style.BackColor == Color.Aquamarine)
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Gold;
                                }
                                if (randomColor == Color.Black || randomColor == Color.MidnightBlue)
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Style.ForeColor = Color.White;
                                }
                            }
                        }
                        else
                        {
                            DateTime fecha = Convert.ToDateTime(tipo);
                            if (fecha >= inicio && fecha <= fin)
                            {
                                gri = new grilla(dia, i, idt);
                                laux.Add(gri);
                                if (ix > 0)
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Value = "X";
                                }
                                else
                                {
                                    this.dataGridView1.Rows[i].Cells[dia].Value = nombre + " " + fecha.ToString("dd/MM/yyyy");
                                    ix++;
                                }
                                this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Orange;
                            }
                        }
                        start = DateTime.Parse(horaini);
                        start1 = DateTime.Parse(horaini);
                        end = DateTime.Parse(horafin);
                        DateTime end1 = end.AddMinutes(-30);
                        while (start < end1)
                        {
                            i++;
                            if (tipo == "")
                            {
                                bool esta = false;

                                foreach (novedades aux in lista)
                                {
                                    DateTime fecha = Convert.ToDateTime(aux.Fecha);
                                    if (Convert.ToInt32(idt) == aux.idTurno)
                                    {
                                        if (fecha >= inicio && fecha <= fin)
                                        {
                                            dt = oacceso.leerDatos("select 'hay turno' as ok, nombre from turnos where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' and idcliente is not null");
                                            bool ok = true;
                                            string n = "";
                                            foreach (DataRow d2r in dt.Rows)
                                            {
                                                if ((Convert.ToString(d2r["ok"])) == "hay turno")
                                                {
                                                    ok = false;
                                                    n = Convert.ToString(d2r["nombre"]);
                                                }
                                                else ok = true;
                                            }
                                            esta = true;
                                            if (ok == true)
                                            {
                                                gri = new grilla(dia, i, idt);
                                                laux.Add(gri);
                                                this.dataGridView1.Rows[i].Cells[dia].Value = "Turno suspendido";
                                                this.dataGridView1.Rows[i].Cells[dia].Style.Font = new Font(this.Font, FontStyle.Bold);
                                                this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Aquamarine;
                                            }
                                            else
                                            {
                                                gri = new grilla(dia, i, idt);
                                                laux.Add(gri);
                                                this.dataGridView1.Rows[i].Cells[dia].Value = n + " " + fecha.ToShortDateString();
                                                this.dataGridView1.Rows[i].Cells[dia].Style.Font = new Font(this.Font, FontStyle.Bold);
                                                this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Aquamarine;
                                            }
                                        }
                                    }
                                }
                                if (esta == false)
                                {
                                    gri = new grilla(dia, i, idt);
                                    laux.Add(gri);
                                    if (ix > 0)
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Value = "X";
                                    }
                                    else
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Value = nombre;
                                    }
                                    this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Red; 
                                    if (this.dataGridView1.Rows[i].Cells[dia].Style.BackColor == Color.Aquamarine)
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Gold;
                                    }
                                    if (randomColor == Color.Black || randomColor == Color.MidnightBlue)
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Style.ForeColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                DateTime fecha = Convert.ToDateTime(tipo);
                                if (fecha >= inicio && fecha <= fin)
                                {
                                    gri = new grilla(dia, i, idt);
                                    laux.Add(gri);
                                    if (ix > 0)
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Value = "X";
                                    }
                                    else
                                    {
                                        this.dataGridView1.Rows[i].Cells[dia].Value = nombre + " " + fecha.ToString("dd/MM/yyyy");
                                        ix++;
                                    }
                                    this.dataGridView1.Rows[i].Cells[dia].Style.BackColor = Color.Orange;
                                }
                            }
                            start1 = start.AddMinutes(30);
                            start = start1;                            
                        }
                        break;
                    }


                    else if (horafin == Convert.ToString(row.Cells[0].Value))
                    {
                        gri = new grilla(dia, dataGridView1.Rows.IndexOf(row) - 1, idt);
                        laux.Add(gri);
                        this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Value = nombre + " " + tipo;

                        this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.BackColor = Color.Red; 
                        if (this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.BackColor == Color.Aquamarine)
                        {
                            this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.BackColor = Color.Gold;
                        }
                        if (randomColor == Color.Black || randomColor == Color.MidnightBlue)
                        {
                            this.dataGridView1.Rows[dataGridView1.Rows.IndexOf(row) - 1].Cells[dia].Style.ForeColor = Color.White;
                        }

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio = inicio.AddDays(7);
            fin = fin.AddDays(7);
            MessageBox.Show("Ha avanzado una semana");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio = inicio.AddDays(-7);
            fin = fin.AddDays(-7);
            MessageBox.Show("Ha retrocedido una semana");
        }

        private void chauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[ro].Cells[col].Style.BackColor != Color.Aquamarine)
            {
                string id = "" ;
                if (dataGridView1.Rows[ro].Cells[col].Value != null)
                {
                    foreach (grilla aux in laux)
                    {
                        if (ro == aux.Fila && col == aux.Columna)
                        {
                            id = aux.Id;
                        }
                    }
                    DialogResult dRe = new DialogResult();
                    dRe = MessageBox.Show("Esta seguro de Eliminar el Turno", "Eliminar Turno", MessageBoxButtons.OKCancel);
                    if (dRe == DialogResult.OK)
                    {
                        oacceso.ActualizarBD("Delete from turnos where idturnos = '" + id + "'");
                        dRe = MessageBox.Show("¿Desea dejar registro de este turno eliminado?", "Eliminar Turno", MessageBoxButtons.OKCancel);
                        if (dRe == DialogResult.OK)
                        {
                            RegistroTurnos frm = new RegistroTurnos();
                            frm.ShowDialog();
                        }
                        MessageBox.Show("Turno eliminado correctamente");
                    }
                }
                else
                {
                    MessageBox.Show("Imposible eliminar, Turno Vacio");
                }
            }
            else
            {
                MessageBox.Show("Imposible eliminar turno suspendido");
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

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[ro].Cells[col].Value != null)
            {                
                string tur = dataGridView1.Rows[ro].Cells[col].Value.ToString();
                string d2 = "";
                foreach (grilla aux in laux)
                {
                    if (ro == aux.Fila && col == aux.Columna)
                    {
                        d2 = aux.Id;
                    }
                }
                Suspender_Turno frm = new Suspender_Turno(d2, tur, col);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Imposible Suspender, Turno Vacio");
            }
        }

        

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = "";
            foreach (grilla aux in laux)
            {
                if (aux.Columna == col && aux.Fila == ro)
                {
                    id = aux.Id;
                }
            }
            string nombre = "";
            string telefono = "";
            string celular = "";
            string comentarios = "";
            DataTable dt = oacceso.leerDatos("select t.nombre, t.telefono, t.celular, n.comentarios as coment, c.descripcion as nomb, c.telefono as tel, c.celular as celu from turnos t left join novedades n on t.idturnos = n.idturno left join clientes c on t.idcliente = c.idclientes where idturnos = '" + id + "'");
            foreach (DataRow dr in dt.Rows)
            {
                nombre = Convert.ToString(dr["nombre"]) + Convert.ToString(dr["nomb"]);
                telefono = Convert.ToString(dr["telefono"]) + Convert.ToString(dr["tel"]);
                celular = Convert.ToString(dr["celular"]) + Convert.ToString(dr["celu"]);
                comentarios = Convert.ToString(dr["coment"]);
            }
            Datos frm = new Datos(nombre, telefono, celular, comentarios);
            frm.Show();
        }

        private void agregarDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = "";
            foreach (grilla aux in laux)
            {
                if (aux.Columna == col && aux.Fila == ro)
                {
                    id = aux.Id;
                }
            }
            Deuda frm = new Deuda(id);
            frm.ShowDialog();
            pnlContainer.Controls.Clear();
            string cmdtest = "select deuda, descripcion, idturnos from turnos t inner join clientes c on t.idcliente = c.idclientes where deuda > 0";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtest);
            foreach (DataRow dr in dt.Rows)
            {
                Button tmpButton = new Button();
                string nombre = Convert.ToString(dr["descripcion"]) + " " + Convert.ToString(dr["deuda"]);
                string name = Convert.ToString(dr["idturnos"]);
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(tmpButton, nombre);
                tmpButton.Name = name;
                tmpButton.Text = nombre;
                tmpButton.Font = new Font("Verdana", 6, FontStyle.Bold);
                tmpButton.Size = new Size(132, 23);
                tmpButton.BackColor = Color.GreenYellow;
                tmpButton.Click += new System.EventHandler(this.manejador_de_evento_botones_generados);
                pnlContainer.Controls.Add(tmpButton);
            }
        }





        

 
    }
}
