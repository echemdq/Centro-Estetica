using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdRubros : IDAO<Rubros>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Rubros dato)
        {
            throw new NotImplementedException();
        }

        public List<Rubros> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Rubros dato)
        {
            throw new NotImplementedException();
        }

        public Rubros Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Rubros> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Rubros dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
