using Gravedad_Zero.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Gravedad_Zero.services
{
    class Navegation
    {
        
        internal void CargarVentanaGestion()
        {
            Gestion nuevaVentana = new Gestion();
            nuevaVentana.ShowDialog();
        }

    }

}
