using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    class grilla
    {
        int columna;
        int fila;
        string id;
        public grilla(int c, int f, string i)
        {
            columna = c;
            fila = f;
            id = i;
        }
        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }
        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
