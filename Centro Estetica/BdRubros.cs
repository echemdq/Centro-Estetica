using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdRubros : IDAO<Rubros>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Rubros dato)
        {
            oacceso.ActualizarBD("insert into rubros (detalle) values ('" + dato.Rubro + "')");
        }

        public List<Rubros> TraerTodos()
        {
            List<Rubros> aux = new List<Rubros>();
            string cmdtext = "select * from rubros order by detalle asc";
            DataTable dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["idrubros"]);
                string detalle = Convert.ToString(dr["detalle"]);
                Rubros c = new Rubros(id, detalle);
                aux.Add(c);
            }
            return aux;
        }

        public void Borrar(Rubros dato)
        {
            oacceso.ActualizarBD("delete from rubros where idrubros = '" + dato.Idrubros + "'");
        }

        public Rubros Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Rubros> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Rubros dato)
        {
            oacceso.ActualizarBD("update rubros set detalle = '"+dato.Rubro+"' where idrubros = '"+dato.Idrubros+"'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
