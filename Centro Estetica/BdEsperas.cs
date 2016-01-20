using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Centro_Estetica
{
    public class BdEsperas : IDAO<Esperas>
    {
        Acceso_BD oacceso = new Acceso_BD();


        public void Agregar(Esperas dato)
        {
            oacceso.ActualizarBD("insert into esperas (nombre, telefono, detalle, fecha) values ('" + dato.Nombre + "','" + dato.Telefono + "','" + dato.Detalle + "','" + dato.Fecha.ToString("yyyy-MM-dd") + "')");
        }

        public List<Esperas> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Esperas dato)
        {
            oacceso.ActualizarBD("delete from esperas where idesperas = '" + dato.Idesperas + "'");
        }

        public Esperas Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Esperas> BuscarEspecial(string dato)
        {
            string cmdtext = "select detalle, telefono, nombre, idesperas from esperas where fecha = '" + dato + "' order by idesperas asc";
            DataTable dt = oacceso.leerDatos(cmdtext);
            Esperas usuario = null;
            List<Esperas> lista = new List<Esperas>();
            foreach (DataRow dr in dt.Rows)
            {
                usuario = new Esperas(Convert.ToInt32(dr["idesperas"]), Convert.ToString(dr["nombre"]), Convert.ToString(dr["telefono"]), Convert.ToString(dr["detalle"]));
                lista.Add(usuario);
            }
            return lista;
        }

        public void Modificar(Esperas dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
