using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraSubrubrosProf : IDAO<SubrubrosProfesionales>
    {
        BdSubrubrosProf bd = new BdSubrubrosProf();
        public void Agregar(SubrubrosProfesionales dato)
        {
            bd.Agregar(dato);
        }

        public List<SubrubrosProfesionales> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(SubrubrosProfesionales dato)
        {
            throw new NotImplementedException();
        }

        public SubrubrosProfesionales Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<SubrubrosProfesionales> BuscarEspecial(string dato)
        {
           return bd.BuscarEspecial(dato);
        }

        public void Modificar(SubrubrosProfesionales dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
