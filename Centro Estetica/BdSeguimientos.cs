using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Centro_Estetica
{
    public class BdSeguimientos : IDAO<Seguimientos>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(Seguimientos dato)
        {
            throw new NotImplementedException();
        }

        public List<Seguimientos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Seguimientos dato)
        {
            throw new NotImplementedException();
        }

        public Seguimientos Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Seguimientos> BuscarEspecial(string dato)
        {
            DataTable dt = oacceso.leerDatos("select s.idseguimientos as idseguimientos, s.idprofesionales as idprofesionales, p.profesional as profesional, s.hora as hora, s.dia as dia, s.detalle as detalle, s.idturnos as idturnos, s.fechareal as fechareal, s.idusuarios as idusuarios from seguimientos s inner join profesionales p on s.idprofesionales = p.idprofesionales " + dato);
            Seguimientos usuario = null;
            List<Seguimientos> lista = new List<Seguimientos>();
            foreach (DataRow dr in dt.Rows)
            {
                Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 0,0,0);
                usuario = new Seguimientos(Convert.ToInt32(dr["idseguimientos"]), p, Convert.ToString(dr["hora"]), Convert.ToDateTime(dr["dia"]), Convert.ToString(dr["detalle"]), Convert.ToInt32(dr["idturnos"]), Convert.ToDateTime(dr["fechareal"]), Convert.ToInt32(dr["idusuarios"]));
                lista.Add(usuario);
            }
            return lista;
        }

        public void Modificar(Seguimientos dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
