using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraProfesionales : IDAO<Profesionales>
    {
        BdProfesionales bd = new BdProfesionales();

        public void Agregar(Profesionales dato)
        {
            throw new NotImplementedException();
        }

        public List<Profesionales> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Profesionales dato)
        {
            throw new NotImplementedException();
        }

        public Profesionales Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Profesionales> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Profesionales dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
