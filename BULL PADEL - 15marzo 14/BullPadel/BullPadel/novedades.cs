using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    class novedades
    {
        int idturno;
        string fecha;
        public novedades(int i, string f)
        {
            idturno = i;
            fecha = f;
        }
        public int idTurno
        {
            get { return idturno; }
            set { idturno = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
