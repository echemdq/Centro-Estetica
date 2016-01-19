using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraEsperas : IDAO<Esperas>
    {
        BdEsperas bd = new BdEsperas();
        public void Agregar(Esperas dato)
        {
            bd.Agregar(dato);
        }

        public List<Esperas> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Esperas dato)
        {
            throw new NotImplementedException();
        }

        public Esperas Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Esperas> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Esperas dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
