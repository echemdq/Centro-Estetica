using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Rubros
    {
        int idrubros;
        string rubro;

        public string Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }

        public int Idrubros
        {
            get { return idrubros; }
            set { idrubros = value; }
        }

        public Rubros(int i, string r)
        {
            idrubros = i;
            rubro = r;
        }
    }
}
