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
    class New: FirebaseDocument
    {
        private string titulo;
        private string texto;
        private DateTime date;
        public New(string titulo, string texto, DateTime date)
        {
            Titulo = titulo;
            Texto = texto;
            Date = date;
        }
        [FirestoreProperty]
        public string Titulo { get => titulo; set => titulo = value; }
        [FirestoreProperty]
        public string Texto { get => texto; set => texto = value; }
        [FirestoreProperty]
        public DateTime Date { get => date; set => date = value; }

    }
}

