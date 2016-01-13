using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class TipoFormasPago
    {
        int idtipoformaspago;
        string forma;
        string idtarjetas;
        string cupon;
        string cuotas;

        public string Cuotas
        {
            get { return cuotas; }
            set { cuotas = value; }
        }

        public string Cupon
        {
            get { return cupon; }
            set { cupon = value; }
        }

        public string Idtarjetas
        {
            get { return idtarjetas; }
            set { idtarjetas = value; }
        } 

        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }

        public int Idtipoformaspago
        {
            get { return idtipoformaspago; }
            set { idtipoformaspago = value; }
        }

        public TipoFormasPago(int i, string f, string idt, string cuo, string cup)
        {
            idtipoformaspago = i;
            forma = f;
            idtarjetas = idt;
            cuotas = cuo;
            cupon = cup;
        }
    }
}
