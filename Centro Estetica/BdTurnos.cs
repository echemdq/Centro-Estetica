using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class BdTurnos : IDAO<Turnos>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(Turnos dato)
        {
            throw new NotImplementedException();
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
