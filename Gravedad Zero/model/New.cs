using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravedad_Zero.model
{
    class New
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

        public string Titulo { get => titulo; set => titulo = value; }
        public string Texto { get => texto; set => texto = value; }
        public DateTime Date { get => date; set => date = value; }

    }
}

