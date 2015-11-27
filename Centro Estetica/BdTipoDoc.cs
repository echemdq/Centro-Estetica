using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdTipoDoc : IDAO<TipoDoc>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(TipoDoc dato)
        {
            throw new NotImplementedException();
        }

        public List<TipoDoc> TraerTodos()
        {
            throw new NotImplementedException();
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
