using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraSubrubros : IDAO<Subrubros>
    {
        BdSubrubros bd = new BdSubrubros();

        public void Agregar(Subrubros dato)
        {
            bd.Agregar(dato);
        }

        public List<Subrubros> TraerTodos()
        {
            return bd.TraerTodos();
        }

        public void Borrar(Subrubros dato)
        {
            bd.Borrar(dato);
        }

        public Subrubros Buscar(string dato)
        {
            return bd.Buscar(dato);
        }

        public List<Subrubros> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Subrubros dato)
        {
            bd.Modificar(dato);
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
