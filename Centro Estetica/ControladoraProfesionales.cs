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
            bd.Agregar(dato);
        }

        public List<Profesionales> TraerTodos()
        {
            return bd.TraerTodos();
        }

        public void Borrar(Profesionales dato)
        {
            bd.Borrar(dato);
        }

        public Profesionales Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Profesionales> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Profesionales dato)
        {
            bd.Modificar(dato);
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
