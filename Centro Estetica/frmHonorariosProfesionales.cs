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
    public partial class frmHonorariosProfesionales : Form
    {
        Productos prod = null;
        ControladoraHonorarios controlh = new ControladoraHonorarios();
        ControladoraProductos controlprod = new ControladoraProductos();
        int idprof = 0;
        bool edito = false;
        Productos prod1 = null;
        public frmHonorariosProfesionales(string id, Productos prod2)
        {
            InitializeComponent();
            idprof = Convert.ToInt32(id);
            prod1 = prod2;
        }

        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtPrecioC.Text.Length; i++)
            {
                if (txtPrecioC.Text[i] == '.')
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

        private void frmHonorariosProfesionales_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Profesional";
                dataGridView1.Columns[1].Name = "Codigo";
                dataGridView1.Columns[2].Name = "Codigo Producto";
                dataGridView1.Columns[3].Name = "Producto";
                dataGridView1.Columns[4].Name = "% Calculo";
                dataGridView1.Columns[1].Visible = false;
                List<Honorarios> l = controlh.BuscarEspecial(idprof.ToString());
                int x = 0;
                if (l.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(l.Count);
                    foreach (Honorarios aux in l)
                    {
                        dataGridView1.Rows[x].Cells[0].Value = aux.Prof.Profesional;
                        dataGridView1.Rows[x].Cells[1].Value = aux.Idhonorarios;
                        dataGridView1.Rows[x].Cells[2].Value = aux.Prod.Idproductos;
                        dataGridView1.Rows[x].Cells[3].Value = aux.Prod.Detalle;
                        dataGridView1.Rows[x].Cells[4].Value = aux.Importe;
                        x++;
                    }
                }
                if (prod1 != null)
                {
                    txtCodigo.Text = prod1.Idproductos.ToString();
                    txtProducto.Text = prod1.Detalle;
                    btnNuevo_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    prod = controlprod.Buscar(txtCodigo.Text);
                    if (prod != null)
                    {
                        txtCodigo.Text = prod.Idproductos.ToString();
                        txtProducto.Text = prod.Detalle;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmBuscaProductos frm = new frmBuscaProductos();
                frm.ShowDialog();
                prod = frm.u;
                if (prod != null)
                {
                    txtCodigo.Text = prod.Idproductos.ToString();
                    txtProducto.Text = prod.Detalle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Profesionales prof = new Profesionales(idprof, "", "", null, "", "", "", 0,0,0);
                if (prod != null)
                {
                    Honorarios h = new Honorarios(0, prod, prof, Convert.ToDecimal(txtPrecioC.Text.Replace('.',',')));
                    if (!edito)
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select ifnull(idhonorarios,0) as idhonorarios from honorarios where idprofesionales = '" + prof.Idprofesionales + "' and idproductos = '" + prod.Idproductos + "'");
                        int existe = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            existe = Convert.ToInt32(dr["idhonorarios"]);
                        }
                        if (existe == 0)
                        {
                            controlh.Agregar(h);
                            MessageBox.Show("Honorario cargado exitosamente");
                        }
                        else
                        {
                            h.Idhonorarios = existe;
                            controlh.Modificar(h);
                            MessageBox.Show("Honorario modificado exitosamente");
                        }
                        frmHonorariosProfesionales_Load(sender, e);
                        txtPrecioC.Enabled = false;
                        txtPrecioC.Text = "0.00";
                        edito = false;
                        prod = null;
                        txtProducto.Text = "";
                        txtCodigo.Text = "";
                    }
                    else
                    {
                        h.Idhonorarios = Convert.ToInt32(label3.Text);
                        controlh.Modificar(h);
                        MessageBox.Show("Honorario modificado exitosamente");
                        frmHonorariosProfesionales_Load(sender, e);
                        txtPrecioC.Enabled = false;
                        txtPrecioC.Text = "0.00";
                        edito = false;
                        prod = null;
                        txtProducto.Text = "";
                        txtCodigo.Text = "";
                    }
                }
                else if (prod1 != null)
                {
                    Honorarios h = new Honorarios(0, prod1, prof, Convert.ToDecimal(txtPrecioC.Text.Replace('.', ',')));
                    if (!edito)
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select ifnull(idhonorarios,0) as idhonorarios from honorarios where idprofesionales = '" + prof.Idprofesionales + "' and idproductos = '" + prod1.Idproductos + "'");
                        int existe = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            existe = Convert.ToInt32(dr["idhonorarios"]);
                        }
                        if (existe == 0)
                        {
                            controlh.Agregar(h);
                            MessageBox.Show("Honorario cargado exitosamente");
                        }
                        else
                        {
                            h.Idhonorarios = existe;
                            controlh.Modificar(h);
                            MessageBox.Show("Honorario modificado exitosamente");
                        }
                        frmHonorariosProfesionales_Load(sender, e);
                        txtPrecioC.Enabled = false;
                        txtPrecioC.Text = "0.00";
                        edito = false;
                        prod = null;
                        txtProducto.Text = "";
                        txtCodigo.Text = "";
                    }
                    else
                    {
                        h.Idhonorarios = Convert.ToInt32(label3.Text);
                        controlh.Modificar(h);
                        MessageBox.Show("Honorario modificado exitosamente");
                        frmHonorariosProfesionales_Load(sender, e);
                        txtPrecioC.Enabled = false;
                        txtPrecioC.Text = "0.00";
                        edito = false;
                        prod = null;
                        txtProducto.Text = "";
                        txtCodigo.Text = "";
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPrecioC.Enabled = true;
            txtPrecioC.Text = "0.00";
            edito = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prod = null;
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtPrecioC.Text = "0.00";
            txtPrecioC.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                edito = true;
                txtPrecioC.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                label3.Text = Convert.ToString(dataGridView1[1, filaseleccionada].Value);
                txtCodigo.Text = dataGridView1[2, filaseleccionada].Value.ToString();
                txtProducto.Text = dataGridView1[3, filaseleccionada].Value.ToString();
                prod = new Productos(0, txtProducto.Text, 0, 0, 0, 0, 0);
                txtPrecioC.Text = dataGridView1[4, filaseleccionada].Value.ToString().Replace(',','.');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (label3.Text != "")
                {
                    Honorarios h = new Honorarios(Convert.ToInt32(label3.Text), null, null, 0);
                    controlh.Borrar(h);
                    MessageBox.Show("Honorario eliminado exitosamente");
                    frmHonorariosProfesionales_Load(sender, e);
                    txtPrecioC.Enabled = false;
                    txtPrecioC.Text = "0.00";
                    edito = false;
                    prod = null;
                    txtProducto.Text = "";
                    txtCodigo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrecioC_KeyPress_1(object sender, KeyPressEventArgs e)
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

            for (int i = 0; i < txtPrecioC.Text.Length; i++)
            {
                if (txtPrecioC.Text[i] == '.')
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
    }
}
