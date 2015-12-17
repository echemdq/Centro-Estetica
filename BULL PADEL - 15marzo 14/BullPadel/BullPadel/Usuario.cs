using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    class Usuario
    {
        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Usuario(int i, string u, string c)
        {
            User = u;
            Contraseña = c;
            Id = i;
        }
    }
}
