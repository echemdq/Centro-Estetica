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

        public void Agregar(Factura dato, List<Facturacion> dato1, TipoFormasPago dato2)
        {
            bd.Agregar(dato, dato1, dato2);
        }

        public void Agregar1(Factura dato, List<Facturacion> dato1, TipoFormasPago dato2)
        {
            bd.Agregar1(dato, dato1, dato2);
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
