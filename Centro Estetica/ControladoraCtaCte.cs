using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraCtaCte
    {
        BdCtaCte bd = new BdCtaCte();
        public void Agregar(Ctacte dato)
        {
            throw new NotImplementedException();
        }

        public List<Ctacte> TraerTodos(string dato)
        {
            return bd.TraerTodos(dato);
        }

        public void Borrar(Ctacte dato)
        {
            throw new NotImplementedException();
        }

        public Ctacte Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Ctacte> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Ctacte dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
