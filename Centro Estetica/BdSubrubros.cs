using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdSubrubros : IDAO<Subrubros>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Subrubros dato)
        {
            throw new NotImplementedException();
        }

        public List<Subrubros> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Subrubros dato)
        {
            throw new NotImplementedException();
        }

        public Subrubros Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Subrubros> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Subrubros dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
