using Gravedad_Zero.view_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gravedad_Zero.views
{
    /// <summary>
    /// Lógica de interacción para GestionBonosUsuarios.xaml
    /// </summary>
    public partial class GestionBonosUsuarios : UserControl
    {
        private GestionBonosUsuariosVM vmGestionBonos;
        public GestionBonosUsuarios()
        {
            InitializeComponent();
            vmGestionBonos = new GestionBonosUsuariosVM();
            this.DataContext = vmGestionBonos;
        }
    }
}
