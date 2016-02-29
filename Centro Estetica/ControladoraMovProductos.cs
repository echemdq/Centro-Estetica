using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraMovProductos : IDAO<MovProductos>
    {
        BdMovProductos bd = new BdMovProductos();
        public void Agregar(MovProductos dato)
        {
            bd.Agregar(dato);
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
