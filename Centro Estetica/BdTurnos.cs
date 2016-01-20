using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class BdTurnos : IDAO<Turnos>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(Turnos dato)
        {
            if (dato.Idservicios != "")
            {
                oacceso.ActualizarBD("insert into turnos (idprofesionales, hora, fecha, idpacientes, detalle, fijo, semana, dia, telefono) values ('" + dato.Profesionales.Idprofesionales + "','" + dato.Hora + "','" + dato.Fecha.ToString("yyyy-MM-dd") + "','" + dato.Paciente + "','" + dato.Detalle + "','" + dato.Fijo + "','" + dato.Semana + "','" + dato.Dia + "','" + dato.Telefono + "'); insert into serviciosturnos (idprofesionales, idservicios, fecha, hora, idpacientes) values ('" + dato.Profesionales.Idprofesionales + "','" + dato.Idservicios + "','" + dato.Fecha.ToString("yyyy-MM-dd") + "','" + dato.Hora + "','"+dato.Paciente+"'); update servicios set usadas = usadas + 1 where idservicios = '" + dato.Idservicios + "'");
            }
            else
            {
                oacceso.ActualizarBD("insert into turnos (idprofesionales, hora, fecha, idpacientes, detalle, fijo, semana, dia, telefono) values ('" + dato.Profesionales.Idprofesionales + "','" + dato.Hora + "','" + dato.Fecha.ToString("yyyy-MM-dd") + "','" + dato.Paciente + "','" + dato.Detalle + "','" + dato.Fijo + "','" + dato.Semana + "','" + dato.Dia + "','" + dato.Telefono + "')");
            }
        }

        public List<Turnos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Turnos dato)
        {
            throw new NotImplementedException();
        }

        public Turnos Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Turnos> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Turnos dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
