using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Ctacte
    {
        int idctacte;
        int idpaciente;
        Factura fact;
        decimal importe;
        decimal cancelado;
        int tipocomp;
        decimal acancelar;

        public decimal Acancelar
        {
            get { return acancelar; }
            set { acancelar = value; }
        }

        public Ctacte(int i, int ip, Factura ifac, decimal imp, decimal can, int t,decimal a)
        {
            idctacte = i;
            idpaciente = ip;
            fact = ifac;
            importe = imp;
            cancelado = can;
            tipocomp = t;
            acancelar = a;
        }

        public int Tipocomp
        {
            get { return tipocomp; }
            set { tipocomp = value; }
        }

        public decimal Cancelado
        {
            get { return cancelado; }
            set { cancelado = value; }
        }

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public Factura Idfacturacion
        {
            get { return fact; }
            set { fact = value; }
        }

        public int Idpaciente
        {
            get { return idpaciente; }
            set { idpaciente = value; }
        }

        public int Idctacte
        {
            get { return idctacte; }
            set { idctacte = value; }
        }
    }
}
