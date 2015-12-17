using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    class Mesas
    {
        int nro;

        public int Nro
        {
            get { return nro; }
            set { nro = value; }
        }
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Mesas(int n, string e)
        {
            Nro = n;
            Estado = e;
        }
    }
}
