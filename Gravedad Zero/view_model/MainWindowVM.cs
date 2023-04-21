using Gravedad_Zero.services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;


namespace Gravedad_Zero.view_model
{
    class MainWindowVM : ObservableObject
    {
        Navegation servicio;

        public RelayCommand Gestion { get; }

        public MainWindowVM()
        {
            servicio = new Navegation();
            Gestion = new RelayCommand(CargarVentenaGestion);
            
        }

        private void CargarVentenaGestion()
        {
            servicio.CargarVentanaGestion();
        }
    }
}
