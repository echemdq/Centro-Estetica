using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class SubrubrosProfesionales
    {
        int idsubprof;
        Subrubros subrubro;
        Profesionales profesional;

        public SubrubrosProfesionales(int i, Subrubros s, Profesionales p)
        {
            idsubprof = i;
            subrubro = s;
            profesional = p;
        }

        public Profesionales Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

        public Subrubros Subrubro
        {
            get { return subrubro; }
            set { subrubro = value; }
        }

        public int Idsubprof
        {
            get { return idsubprof; }
            set { idsubprof = value; }
        }
    }
}
