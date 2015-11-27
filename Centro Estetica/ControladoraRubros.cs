using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraRubros : IDAO<Rubros>
    {
        BdRubros bd = new BdRubros();

        public void Agregar(Rubros dato)
        {
            bd.Agregar(dato);
        }

        public List<Rubros> TraerTodos()
        {
            return bd.TraerTodos();
        }

        public void Borrar(Rubros dato)
        {
            bd.Borrar(dato);
        }

        public Rubros Buscar(string dato)
        {
            return bd.Buscar(dato);
        }

        public List<Rubros> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Rubros dato)
        {
            bd.Modificar(dato);
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
