using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Turnos
    {
        int idturnos;
        Profesionales profesionales;
        string hora;
        DateTime fecha;
        string paciente;
        string detalle;
        string fijo;
        string semana;
        string dia;
        string telefono;
        string idservicios;

        public string Idservicios
        {
            get { return idservicios; }
            set { idservicios = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        

        public string Semana
        {
            get { return semana; }
            set { semana = value; }
        }

        public string Fijo
        {
            get { return fijo; }
            set { fijo = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public Profesionales Profesionales
        {
            get { return profesionales; }
            set { profesionales = value; }
        }

        public int Idturnos
        {
            get { return idturnos; }
            set { idturnos = value; }
        }
        string sesion;

        public string Sesion
        {
            get { return sesion; }
            set { sesion = value; }
        }

        public Turnos(int i, Profesionales p, string h, DateTime f, string pa, string d, string fi, string s, string di, string t, string idserv, string ses)
        {
            idturnos = i;
            profesionales = p;
            hora = h;
            fecha = f;
            paciente = pa;
            detalle = d;
            fijo = fi;
            semana = s;
            dia = di;
            telefono = t;
            idservicios = idserv;
            sesion = ses;
        }
    }
}
