using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class MovCajas
    {
        int idmovcajas;
        string tipo;
        decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Idmovcajas
        {
            get { return idmovcajas; }
            set { idmovcajas = value; }
        }
    }
}
