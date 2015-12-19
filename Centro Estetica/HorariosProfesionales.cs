using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class HorariosProfesionales
    {
        int idhorariosprofesionales;
        Profesionales profesionales;
        string ingreso;
        string egreso;
        DateTime desde;
        DateTime hasta;
        string lunes;
        string martes;
        string miercoles;
        string jueves;
        string viernes;
        string sabado;
        string domingo;
        string semana;

        public string Semana
        {
            get { return semana; }
            set { semana = value; }
        }


        public string Domingo
        {
            get { return domingo; }
            set { domingo = value; }
        }

        public string Sabado
        {
            get { return sabado; }
            set { sabado = value; }
        }

        public string Viernes
        {
            get { return viernes; }
            set { viernes = value; }
        }

        public string Jueves
        {
            get { return jueves; }
            set { jueves = value; }
        }

        public string Miercoles
        {
            get { return miercoles; }
            set { miercoles = value; }
        }

        public string Martes
        {
            get { return martes; }
            set { martes = value; }
        }

        public string Lunes
        {
            get { return lunes; }
            set { lunes = value; }
        }

        public DateTime Hasta
        {
            get { return hasta; }
            set { hasta = value; }
        }

        public DateTime Desde
        {
            get { return desde; }
            set { desde = value; }
        }

        public string Egreso
        {
            get { return egreso; }
            set { egreso = value; }
        }

        public string Ingreso
        {
            get { return ingreso; }
            set { ingreso = value; }
        }

        public Profesionales Profesionales
        {
            get { return profesionales; }
            set { profesionales = value; }
        }

        public int IdhorariosProfesionales
        {
            get { return idhorariosprofesionales; }
            set { idhorariosprofesionales = value; }
        }

        public HorariosProfesionales(int i, Profesionales p, string ing, string eg, DateTime d, DateTime h, string l, string m, string mi, string j, string v, string s, string dom, string sem)
        {
            idhorariosprofesionales = i;
            profesionales = p;
            ingreso = ing;
            egreso = eg;
            desde = d;
            hasta = h;
            lunes = l;
            martes = m;
            miercoles = mi;
            jueves = j;
            viernes = v;
            sabado = s;
            domingo = dom;
            semana = sem;
        }

        public HorariosProfesionales(int i, Profesionales p, string ing, string eg, DateTime d, string l, string m, string mi, string j, string v, string s, string dom, string sem)
        {
            idhorariosprofesionales = i;
            profesionales = p;
            ingreso = ing;
            egreso = eg;
            desde = d;
            lunes = l;
            martes = m;
            miercoles = mi;
            jueves = j;
            viernes = v;
            sabado = s;
            domingo = dom;
            semana = sem;
        }
    }
}
