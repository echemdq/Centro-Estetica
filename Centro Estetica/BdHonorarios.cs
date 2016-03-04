using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdHonorarios : IDAO<Honorarios>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Honorarios dato)
        {
            oacceso.ActualizarBD("insert into honorarios (idprofesionales, idproductos, preciocalculo) select * from ( select '" + dato.Prof.Idprofesionales + "','" + dato.Prod.Idproductos + "','" + dato.Importe.ToString().Replace(',', '.') + "') as tmp where not exists (select * from honorarios where idprofesionales = '" + dato.Prof.Idprofesionales + "' and idproductos = '" + dato.Prod.Idproductos + "') LIMIT 1;");
        }

        public List<Honorarios> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Honorarios dato)
        {
            oacceso.ActualizarBD("delete from honorarios where idhonorarios = '" + dato.Idhonorarios + "'");
        }

        public Honorarios Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Honorarios> BuscarEspecial(string dato)
        {
            DataTable dt = oacceso.leerDatos("select h.idhonorarios as idhonorarios, h.idprofesionales as idprof, p.profesional as profesional, h.idproductos as idproductos, pr.detalle as producto, h.preciocalculo as precio from honorarios h inner join profesionales p on h.idprofesionales = p.idprofesionales inner join productos pr on h.idproductos = pr.idproductos where h.idprofesionales = '" + dato + "'");
            List<Honorarios> lista = new List<Honorarios>();
            foreach (DataRow dr in dt.Rows)
            {
                Profesionales prof = new Profesionales(Convert.ToInt32(dr["idprof"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 0,0,0);
                Productos prod = new Productos(Convert.ToInt32(dr["idproductos"]), Convert.ToString(dr["producto"]), 0, 0, 0, 0, 0);
                Honorarios h = new Honorarios(Convert.ToInt32(dr["idhonorarios"]), prod, prof, Convert.ToDecimal(dr["precio"]));
                lista.Add(h);
            }
            return lista;
        }

        public void Modificar(Honorarios dato)
        {
            oacceso.ActualizarBD("update honorarios set preciocalculo = '" + dato.Importe.ToString().Replace(',', '.') + "' where idhonorarios = '" + dato.Idhonorarios + "'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
