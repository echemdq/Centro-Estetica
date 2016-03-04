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
    public partial class frmMovCaja : Form
    {
        public frmMovCaja()
        {
            InitializeComponent();
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioV.Text.Length; i++)
            {
                if (txtPrecioV.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void frmMovCaja_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            List<TipoMovCajas> laux = new List<TipoMovCajas>();
            Acceso_BD oacceso = new Acceso_BD();
            DataTable dt = oacceso.leerDatos("select * from tipomovcajas");
            foreach (DataRow dr in dt.Rows)
            {
                TipoMovCajas t = new TipoMovCajas(Convert.ToInt32(dr["idtipomovcajas"]), Convert.ToString(dr["detalle"]));
                laux.Add(t);
            }
            if (laux.Count != 0)
            {
                cmbrubro.DataSource = laux;
                cmbrubro.DisplayMember = "detalle";
                cmbrubro.ValueMember = "idtipo";
                cmbrubro.SelectedIndex = 0;
            }
            dt = oacceso.leerDatos("select m.idmovcajas as id, m.tipo as tipo, t.detalle as rubro, m.detalle as detalle, importe, fecha from movcajas m left join tipomovcajas t on m.idtipomovcajas = t.idtipomovcajas where fecha = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' union select l.idliquidaciondiaria as id, 'EGRESO' as tipo, 'LIQUIDACION HONORARIO' as rubro, p.profesional, importe, fecha from liquidaciondiaria l left join profesionales p on l.idprofesionales = p.idprofesionales where fecha = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "idtipomov";
            dataGridView1.Columns[1].Name = "Tipo de Movimiento";
            dataGridView1.Columns[2].Name = "Rubro";
            dataGridView1.Columns[3].Name = "Detalle";
            dataGridView1.Columns[4].Name = "Importe";
            dataGridView1.Columns[5].Name = "Fecha";
            dataGridView1.Columns[0].Visible = false;
            int x = 0;
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[x].Cells[0].Value = Convert.ToInt32(dr["id"]); ;
                dataGridView1.Rows[x].Cells[1].Value = Convert.ToString(dr["tipo"]);
                dataGridView1.Rows[x].Cells[2].Value = Convert.ToString(dr["rubro"]);
                dataGridView1.Rows[x].Cells[3].Value = Convert.ToString(dr["detalle"]);
                dataGridView1.Rows[x].Cells[4].Value = Convert.ToString(dr["importe"]);
                DateTime fech = Convert.ToDateTime(dr["fecha"]);
                dataGridView1.Rows[x].Cells[5].Value = fech.ToString("dd/MM/yyyy");
                x++;
            }

        }

        private void cmbrubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == 13)
                {
                    Acceso_BD oacceso = new Acceso_BD();
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de Agregar el nuevo rubro: " + cmbrubro.Text, "Agrega Rubro", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        oacceso.ActualizarBD("insert into tipomovcajas (detalle) values ('" + cmbrubro.Text + "')");
                        frmMovCaja_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                Acceso_BD oacceso = new Acceso_BD();
                oacceso.ActualizarBD("insert into movcajas (idtipomovcajas, detalle, importe, fecha, tipo) values ('" + cmbrubro.SelectedValue + "','" + textBox1.Text + "','" + txtPrecioV.Text + "','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "','" + comboBox1.Text + "')");
                txtPrecioV.Text = "0.00";
                textBox1.Text = "";
                frmMovCaja_Load(sender, e);

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
                int fila = dataGridView1.CurrentRow.Index;
                if (dataGridView1.Rows[fila].Cells[0].Value.ToString() != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el movimiento: " + dataGridView1.Rows[fila].Cells[1].Value.ToString(), "Eliminar movimiento", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (dataGridView1.Rows[fila].Cells[2].Value.ToString().Equals("LIQUIDACION HONORARIO"))
                        {
                            Acceso_BD oa = new Acceso_BD();
                            oa.ActualizarBD("delete from liquidaciondiaria where idliquidaciondiaria = '" + dataGridView1.Rows[fila].Cells[0].Value + "'");
                        }
                        else
                        {
                            Acceso_BD oa = new Acceso_BD();
                            oa.ActualizarBD("delete from movcajas where idmovcajas = '" + dataGridView1.Rows[fila].Cells[0].Value + "'");
                        }
                        MessageBox.Show("Movimiento eliminado exitosamente");
                        frmMovCaja_Load(sender, e);
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
