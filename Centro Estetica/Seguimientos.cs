using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Seguimientos
    {
        int idseguimientos;
        Profesionales profesionales;
        string hora;
        DateTime dia;
        string detalle;
        int idturnos;
        DateTime fechareal;
        int idusuarios;

        

        public int Idusuarios
        {
            get { return idusuarios; }
            set { idusuarios = value; }
        }

        public DateTime Fechareal
        {
            get { return fechareal; }
            set { fechareal = value; }
        }

        public int Idturnos
        {
            get { return idturnos; }
            set { idturnos = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public DateTime Dia
        {
            get { return dia; }
            set { dia = value; }
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


        public int Idseguimientos
        {
            get { return idseguimientos; }
            set { idseguimientos = value; }
        }

        public Seguimientos(int i, Profesionales p, string h, DateTime d, string det, int idt, DateTime f, int idu)
        {
            idseguimientos = i;
            profesionales = p;
            hora = h;
            dia = d;
            detalle = det;
            idturnos = idt;
            fechareal = f;
            idusuarios = idu;
        }

    }
}
