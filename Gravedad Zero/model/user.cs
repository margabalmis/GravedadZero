using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravedad_Zero.model
{
    class User
    {
        private string email;
        private string nick;
        private int bonos;

        public User(string email, string nick, int bonos)
        {
            Email = email;
            Nick = nick;
            Bonos = bonos;
        }

        public string Email { get => email; set => email = value; }
        public string Nick { get => nick; set => nick = value; }
        public int Bonos { get => bonos; set => bonos = value; }

    }
}
