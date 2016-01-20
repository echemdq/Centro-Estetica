using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraServicios : IDAO<Servicios>
    {
        BdServicios bd = new BdServicios();
        public void Agregar(Servicios dato)
        {
            throw new NotImplementedException();
        }

        public List<Servicios> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Servicios dato)
        {
            throw new NotImplementedException();
        }

        public Servicios Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Servicios> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Servicios dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
