using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Honorarios
    {
        int idhonorarios;
        Profesionales prof;
        Productos prod;
        int tipo; // 0 costo fijo - 1 porcentaje
        decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Productos Prod
        {
            get { return prod; }
            set { prod = value; }
        }

        public Profesionales Prof
        {
            get { return prof; }
            set { prof = value; }
        }

        public int Idhonorarios
        {
            get { return idhonorarios; }
            set { idhonorarios = value; }
        }
        public Honorarios(int i, Productos pro, Profesionales p, decimal im)
        {
            idhonorarios = i;
            prod = pro;
            prof = p;
            importe = im;
        }
    }
}
