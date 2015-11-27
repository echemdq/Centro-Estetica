using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class ControladoraTipoDoc : IDAO<TipoDoc>
    {
        BdTipoDoc bd = new BdTipoDoc();

        public void Agregar(TipoDoc dato)
        {
            throw new NotImplementedException();
        }

        public List<TipoDoc> TraerTodos()
        {
            return bd.TraerTodos();
        }

        public void Borrar(TipoDoc dato)
        {
            throw new NotImplementedException();
        }

        public TipoDoc Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<TipoDoc> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(TipoDoc dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
