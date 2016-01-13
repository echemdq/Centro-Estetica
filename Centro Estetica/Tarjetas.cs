using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Tarjetas
    {
        int idtarjetas;

        public int Idtarjetas
        {
            get { return idtarjetas; }
            set { idtarjetas = value; }
        }
        string tarjeta;

        public string Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

        public Tarjetas(int i, string t)
        {
            tarjeta = t;
            idtarjetas = i;
        }
    }
}
