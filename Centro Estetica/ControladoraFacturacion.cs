using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraFacturacion
    {
        BdFacturacion bd = new BdFacturacion();

        public string Agregar(Factura dato, List<Facturacion> dato1)
        {
            return bd.Agregar(dato, dato1);
        }

        public string Agregar1(Factura dato, List<Facturacion> dato1)
        {
            return bd.Agregar1(dato, dato1);
        }

        public void AgregarFP(TipoFormasPago dato2, string d)
        {
            bd.AgregarFP(dato2, d);
        }
        public void AgregarFPC(TipoFormasPago dato2, string d, string p)
        {
            bd.AgregarFPC(dato2, d, p);
        }
        public void Agregar2(Factura dato, List<Ctacte> dato1, TipoFormasPago dato2)
        {
            bd.Agregar2(dato, dato1, dato2);
        }

        public void Borrar(Factura dato)
        {
            throw new NotImplementedException();
        }  

        public void Modificar(Factura dato)
        {
            throw new NotImplementedException();
        }
    }
}
