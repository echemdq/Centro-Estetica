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
            DataTable dt = oacceso.leerDatos("select * from servicios where idpacientes = '" + dato + "' and usadas < sesiones and fecha >= DATE_SUB(curdate(), INTERVAL 30 DAY)");
            List<Servicios> lista = new List<Servicios>();
            foreach (DataRow dr in dt.Rows)
            {
                Servicios s = new Servicios(Convert.ToInt32(dr["idservicios"]), Convert.ToInt32(dr["idproductos"]), Convert.ToString(dr["detalle"]), Convert.ToInt32(dr["sesiones"]), Convert.ToInt32(dr["usadas"]), Convert.ToInt32(dr["idfacturacion"]), Convert.ToInt32(dr["idpacientes"]));
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
