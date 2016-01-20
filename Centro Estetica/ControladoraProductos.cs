using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraProductos : IDAO<Productos>
    {
        BdProductos bd = new BdProductos();
        public void Agregar(Productos dato)
        {
            bd.Agregar(dato);
        }

        public List<Productos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Productos dato)
        {
            bd.Borrar(dato);
        }

        public Productos Buscar(string dato)
        {
            return bd.Buscar(dato);
        }

        public List<Productos> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Productos dato)
        {
            bd.Modificar(dato);
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
