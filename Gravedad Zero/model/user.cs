using Google.Cloud.Firestore;
using Gravedad_Zero.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravedad_Zero.model
{
    [FirestoreData]
    class User : FirebaseDocument
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
        [FirestoreProperty]
        public string Email { get => email; set => email = value; }
        [FirestoreProperty]
        public string Nick { get => nick; set => nick = value; }
        [FirestoreProperty]
        public int Bonos { get => bonos; set => bonos = value; }

    }
}
