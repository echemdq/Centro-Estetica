using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraSeguimientos : IDAO<Seguimientos>
    {
        BdSeguimientos bd = new BdSeguimientos();
        public void Agregar(Seguimientos dato)
        {
            throw new NotImplementedException();
        }

        public List<Seguimientos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Seguimientos dato)
        {
            throw new NotImplementedException();
        }

        public Seguimientos Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Seguimientos> BuscarEspecial(string dato)
        {
            return bd.BuscarEspecial(dato);
        }

        public void Modificar(Seguimientos dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
