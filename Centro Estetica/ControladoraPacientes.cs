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
            bd.Agregar(dato);
        }

        public List<Pacientes> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Pacientes dato)
        {
            bd.Borrar(dato);
        }

        public Pacientes Buscar(string dato)
        {
            return bd.Buscar(dato);
        }

        public List<Pacientes> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Pacientes dato)
        {
            bd.Modificar(dato);
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
