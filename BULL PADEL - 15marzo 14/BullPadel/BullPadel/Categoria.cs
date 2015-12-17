using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    public class Categoria
    {
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Categoria(string d)
        {
            Descripcion = d;
        }
    }
}
