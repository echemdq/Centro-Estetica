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
    public partial class frmInfCajas : Form
    {
        Acceso_BD oac = new Acceso_BD();
        public frmInfCajas()
        {
            InitializeComponent();
        }

        private void frmInfCajas_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString();
            maskedTextBox2.Text = DateTime.Now.ToString();
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
            DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
            h = h.AddDays(1).AddSeconds(-1);
            dataGridView1.DataSource = oac.leerDatos("select concat(case when tipocomp = '1' then 'Factura ' else case when tipocomp = '2' then 'Recibo ' else 'Nota de Credito' end end, CAST(ptoventa AS CHAR),' - ',CAST(factura AS CHAR)) as Factura, fecha as Fecha, detalle as Detalle, f.total as Total, t.tipo as 'Forma Pago', ta.tarjeta, fp.cupon, fp.cuotas, f.bonificacion as 'Bonificacion(+) o Recargo(-)' from facturacion f left join formasdepago fp on f.idfacturacion = fp.idfacturacion left join tipoformaspago t on fp.idtipoformaspago = t.idtipoformaspago left join tarjetas ta on ta.idtarjetas = fp.idtarjetas where f.fecha between '" + d.ToString("yyyy-MM-dd") + "' and '" + h.ToString("yyyy-MM-dd HH:mm:ss") + "' order by fecha");
            dataGridView3.DataSource = oac.leerDatos("select l.idliquidaciondiaria as id, l.fecha as Fecha, 'Honorarios prof' as Rubro, p.profesional as Detalle, l.importe as Importe, 'EGRESO' as Movimiento from liquidaciondiaria l left join profesionales p on l.idprofesionales = p.idprofesionales where l.fecha between '" + d.ToString("yyyy-MM-dd") + "' and '" + h.ToString("yyyy-MM-dd HH:mm:ss") + "' union select m.idmovcajas as id, m.fecha as Fecha, t.detalle as Rubro, m.detalle as Detalle, m.importe as Importe, m.tipo as Movimiento from movcajas m left join tipomovcajas t on m.idtipomovcajas = t.idtipomovcajas where m.fecha between '" + d.ToString("yyyy-MM-dd") + "' and '" + h.ToString("yyyy-MM-dd HH:mm:ss") + "' order by fecha");
            dataGridView3.Columns[0].Visible = false;
            DataTable dt = oac.leerDatos("select ifnull(sum(f.total),0) as total, t.tipo as 'forma' from facturacion f left join formasdepago fp on f.idfacturacion = fp.idfacturacion left join tipoformaspago t on fp.idtipoformaspago = t.idtipoformaspago where f.fecha between '" + d.ToString("yyyy-MM-dd") + "' and '" + h.ToString("yyyy-MM-dd HH:mm:ss") + "' group by t.tipo union select ifnull(sum(case when tipo = 'INGRESO' then importe else importe * (-1) end),0) as total, 'EFECTIVO' as 'forma' from movcajas where fecha between '" + d.ToString("yyyy-MM-dd") + "' and '" + h.ToString("yyyy-MM-dd HH:mm:ss") + "' union select ifnull(sum(importe * (-1)),0) as total, 'EFECTIVO' as 'forma' from liquidaciondiaria where fecha between '" + d.ToString("yyyy-MM-dd") + "' and '" + h.ToString("yyyy-MM-dd HH:mm:ss") + "'");
            List<TotalesCaja> list = new List<TotalesCaja>();
            foreach (DataRow dr in dt.Rows)
            {
                TotalesCaja t = new TotalesCaja(Convert.ToString(dr["forma"]), Convert.ToDecimal(dr["total"]));
                int existe = 0;
                foreach (TotalesCaja aux in list)
                {
                    if (aux.Detalle.Equals(t.Detalle))
                    {
                        existe = 1;
                        aux.Total = aux.Total + t.Total;
                        break;
                    }
                    else
                    {
                        existe = 0;
                    }
                }
                if (existe == 0)
                {
                    list.Add(t);
                }
            }
            dataGridView2.DataSource = list;
            decimal total = 0;
            foreach (TotalesCaja aux in list)
            {
                total = total + aux.Total;
            }
            label3.Text = "Total acumulado: " + total;
        }
    }
}
