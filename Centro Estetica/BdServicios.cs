using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Centro_Estetica
{
    public class BdServicios : IDAO<Servicios>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(Servicios dato)
        {
            throw new NotImplementedException();
        }

        public List<Servicios> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Servicios dato)
        {
            throw new NotImplementedException();
        }

        public Servicios Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Servicios> BuscarEspecial(string dato)
        {
            DataTable dt = oacceso.leerDatos("select s.idservicios, s.idproductos, s.detalle, s.sesiones, s.usadas, s.idlineafactura, s.idpacientes, f.comentario from servicios s left join lineafactura lf on s.idlineafactura = lf.idlineafactura left join facturacion f on lf.idfacturacion = f.idfacturacion where s.idpacientes = '"+dato+"' and s.usadas < s.sesiones and s.fecha >= DATE_SUB(curdate(), INTERVAL 30 DAY) and f.regalo = '1'");
            List<Servicios> lista = new List<Servicios>();
            foreach (DataRow dr in dt.Rows)
            {
                Servicios s = new Servicios(Convert.ToInt32(dr["idservicios"]), Convert.ToInt32(dr["idproductos"]), Convert.ToString(dr["detalle"]), Convert.ToInt32(dr["sesiones"]), Convert.ToInt32(dr["usadas"]), Convert.ToInt32(dr["idlineafactura"]), Convert.ToInt32(dr["idpacientes"]), Convert.ToString(dr["comentario"]));
                lista.Add(s);
            }
            return lista;
        }

        public void Modificar(Servicios dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
