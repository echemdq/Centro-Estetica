using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraHorariosProfesionales : IDAO<HorariosProfesionales>
    {
        BdHorariosProfesionales bd = new BdHorariosProfesionales();
        public void Agregar(HorariosProfesionales dato)
        {
            bd.Agregar(dato);
        }

        public List<HorariosProfesionales> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(HorariosProfesionales dato)
        {
            bd.Borrar(dato);
        }

        public HorariosProfesionales Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<HorariosProfesionales> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(HorariosProfesionales dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
