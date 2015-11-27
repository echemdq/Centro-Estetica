using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraPacientes : IDAO<Pacientes>
    {
        BdPacientes bd = new BdPacientes();

        public void Agregar(Pacientes dato)
        {
            throw new NotImplementedException();
        }

        public List<Pacientes> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Pacientes dato)
        {
            throw new NotImplementedException();
        }

        public Pacientes Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Pacientes> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Pacientes dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
