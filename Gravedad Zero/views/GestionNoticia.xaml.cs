using Gravedad_Zero.view_model;
using System.Windows.Controls;


namespace Gravedad_Zero.views
{
    /// <summary>
    /// Lógica de interacción para GestionNoticia.xaml
    /// </summary>
    public partial class GestionNoticia : UserControl
    {
        private GestionNoticiaVM vmGestionNoticia;
        public GestionNoticia()
        {
            InitializeComponent();
            vmGestionNoticia = new GestionNoticiaVM();
            this.DataContext = vmGestionNoticia;
        }
    }
}

