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
    public partial class frmDatosTurnoSalon : Form
    {
        int id = 0;
        public frmDatosTurnoSalon(int i)
        {
            InitializeComponent();
            id = i;
        }

        private void frmDatosTurnoSalon_Load(object sender, EventArgs e)
        {
            Acceso_BD oa = new Acceso_BD();
            DataTable dt = oa.leerDatos("select * from turnossalon where idturnossalon = '" + id + "'");
            foreach (DataRow dr in dt.Rows)
            {
                txtCelular.Text = Convert.ToString(dr["celular"]);
                txtDuracion.Value = Convert.ToInt32(dr["cantidad"]);
                txtFecha.Text = Convert.ToString(dr["fecha"]);
                txtHora.Text = Convert.ToString(dr["ingreso"]);
                txtNombre.Text = Convert.ToString(dr["nombre"]);
                txtTelefono.Text = Convert.ToString(dr["telefono"]);
            }
        }
    }
}
