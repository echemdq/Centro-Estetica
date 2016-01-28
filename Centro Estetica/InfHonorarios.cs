using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class InfHonorarios
    {
        string profesional;
        string paciente;
        string detalle;
        string sesiones;
        string precioventa;
        string prueba;
        decimal pagoprofesional;

        public InfHonorarios(string pr, string pa, string de, string se, string pv, string pb, decimal pp)
        {
            profesional = pr;
            paciente = pa;
            detalle = de;
            sesiones = se;
            precioventa = pv;
            prueba = pb;
            pagoprofesional = pp;
        }

        public decimal Pagoprofesional
        {
            get { return pagoprofesional; }
            set { pagoprofesional = value; }
        }

        public string Prueba
        {
            get { return prueba; }
            set { prueba = value; }
        }

        public string Precioventa
        {
            get { return precioventa; }
            set { precioventa = value; }
        }

        public string Sesiones
        {
            get { return sesiones; }
            set { sesiones = value; }
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

        public string Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

    }
}
