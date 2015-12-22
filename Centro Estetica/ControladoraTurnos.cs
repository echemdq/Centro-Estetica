using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraTurnos : IDAO<Turnos>
    {
        BdTurnos bd = new BdTurnos();
        public void Agregar(Turnos dato)
        {
            bd.Agregar(dato);
        }

        public List<Turnos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Turnos dato)
        {
            throw new NotImplementedException();
        }

        public Turnos Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Turnos> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Turnos dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
