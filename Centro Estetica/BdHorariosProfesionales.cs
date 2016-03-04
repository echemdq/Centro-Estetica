using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdHorariosProfesionales : IDAO<HorariosProfesionales>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(HorariosProfesionales dato)
        {
            string hasta = dato.Hasta.ToShortDateString();
            if (hasta == "01/01/0001")
            {
                oacceso.ActualizarBD("insert into horariosprofesionales (idprofesionales, ingreso, egreso, desde, hasta, lunes, martes, miercoles, jueves, viernes, sabado, domingo, semana) values ('" + dato.Profesionales.Idprofesionales + "','" + dato.Ingreso + "','" + dato.Egreso + "','" + dato.Desde.ToString("yyyy/MM/dd") + "','1900/01/01','" + dato.Lunes + "','" + dato.Martes + "','" + dato.Miercoles + "','" + dato.Jueves + "','" + dato.Viernes + "','" + dato.Sabado + "','" + dato.Domingo + "','"+dato.Semana+"')");
            }
            else
            {
                oacceso.ActualizarBD("insert into horariosprofesionales (idprofesionales, ingreso, egreso, desde, hasta, lunes, martes, miercoles, jueves, viernes, sabado, domingo, semana) values ('" + dato.Profesionales.Idprofesionales + "','" + dato.Ingreso + "','" + dato.Egreso + "','" + dato.Desde.ToString("yyyy/MM/dd") + "','" + dato.Hasta.ToString("yyyy/MM/dd") + "','" + dato.Lunes + "','" + dato.Martes + "','" + dato.Miercoles + "','" + dato.Jueves + "','" + dato.Viernes + "','" + dato.Sabado + "','" + dato.Domingo + "','" + dato.Semana + "')");
            }
        }

        public List<HorariosProfesionales> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(HorariosProfesionales dato)
        {
            oacceso.ActualizarBD("delete from horariosprofesionales where idhorariosprofesionales ='" + dato.IdhorariosProfesionales + "'");
        }

        public HorariosProfesionales Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<HorariosProfesionales> BuscarEspecial(string dato)
        {
            List<HorariosProfesionales> aux = new List<HorariosProfesionales>();
            string cmdtext = "select h.idhorariosprofesionales as idhorariosprofesionales, h.idprofesionales as idprofesionales, h.ingreso as ingreso, h.egreso as egreso, h.desde as desde, h.hasta as hasta, h.lunes as lunes, h.martes as martes, h.miercoles as miercoles, h.jueves as jueves, h.viernes as viernes, h.sabado as sabado, h.domingo as domingo, h.semana as semana from horariosprofesionales h inner join profesionales p on h.idprofesionales = p.idprofesionales  where h.idprofesionales = '" + dato + "'";
            DataTable dt = oacceso.leerDatos(cmdtext);
            DateTime hasta = Convert.ToDateTime("1900/01/01");
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["idhorariosprofesionales"]);
                string ingreso = Convert.ToString(dr["ingreso"]);
                string egreso = Convert.ToString(dr["egreso"]);
                if (Convert.ToString(dr["hasta"]) != "")
                {
                    hasta = Convert.ToDateTime(dr["hasta"]);
                }
                DateTime desde = Convert.ToDateTime(dr["desde"]);
                string lunes = Convert.ToString(dr["lunes"]);
                string martes = Convert.ToString(dr["martes"]);
                string miercoles = Convert.ToString(dr["miercoles"]);
                string jueves = Convert.ToString(dr["jueves"]);
                string viernes = Convert.ToString(dr["viernes"]);
                string sabado = Convert.ToString(dr["sabado"]);
                string domingo = Convert.ToString(dr["domingo"]);
                string semana = Convert.ToString(dr["semana"]);
                Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), "", "", null, "", "", "", 0,0,0);
                HorariosProfesionales c = new HorariosProfesionales(id, p, ingreso, egreso, desde, hasta, lunes, martes, miercoles, jueves, viernes, sabado, domingo, semana);
                aux.Add(c);
            }
            return aux;
        }

        public void Modificar(HorariosProfesionales dato)
        {
            oacceso.ActualizarBD("update horariosprofesionales set hasta = '" + dato.Hasta.ToString("yyyy/MM/dd") + "' where idhorariosprofesionales = '" + dato.IdhorariosProfesionales + "'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
