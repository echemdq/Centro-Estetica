﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdHonorarios : IDAO<Honorarios>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Honorarios dato)
        {
            throw new NotImplementedException();
        }

        public List<Honorarios> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Honorarios dato)
        {
            throw new NotImplementedException();
        }

        public Honorarios Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Honorarios> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Honorarios dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
