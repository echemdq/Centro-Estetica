using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class BdMovProductos : IDAO<MovProductos>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(MovProductos dato)
        {
            if(dato.Tipomov.Equals("INGRESO"))
            {
                oacceso.ActualizarBD("begin; update productos set stock = stock + '" + dato.Cantidad + "' where idproductos = '" + dato.Idproductos + "'; insert into movproductos (tipomov, idproductos, producto, cantidad, detalle, responsable, consignacion, fecha) values('" + dato.Tipomov + "','" + dato.Idproductos + "','" + dato.Producto + "','" + dato.Cantidad + "','" + dato.Detalle + "','" + dato.Responsable + "','" + dato.Consignacion + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'); commit;");
            }
            else
            {
                oacceso.ActualizarBD("begin; update productos set stock = stock - '" + dato.Cantidad + "' where idproductos = '" + dato.Idproductos + "'; insert into movproductos (tipomov, idproductos, producto, cantidad, detalle, responsable, consignacion, fecha) values('" + dato.Tipomov + "','" + dato.Idproductos + "','" + dato.Producto + "','" + dato.Cantidad + "','" + dato.Detalle + "','" + dato.Responsable + "','" + dato.Consignacion + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'); commit;");
            }
        }

        public List<MovProductos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(MovProductos dato)
        {
            throw new NotImplementedException();
        }

        public MovProductos Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<MovProductos> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(MovProductos dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
