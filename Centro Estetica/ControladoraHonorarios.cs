using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraHonorarios : IDAO<Honorarios>
    {
        BdHonorarios bd = new BdHonorarios();

        public void Agregar(Honorarios dato)
        {
            bd.Agregar(dato);
        }

        public List<Honorarios> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Honorarios dato)
        {
            bd.Borrar(dato);
        }

        public Honorarios Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Honorarios> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Honorarios dato)
        {
            bd.Modificar(dato);
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
