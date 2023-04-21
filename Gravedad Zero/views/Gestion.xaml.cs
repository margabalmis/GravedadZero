using Gravedad_Zero.view_model;
using System.Windows;


namespace Gravedad_Zero.views
{
    /// <summary>
    /// Lógica de interacción para Gestion.xaml
    /// </summary>
    /// 
    
    public partial class Gestion : Window
    {
        private GestionVM vmGestion;
        public Gestion()
        {
            InitializeComponent();
            vmGestion = new GestionVM();
            this.DataContext = vmGestion;
        }

    }
}

