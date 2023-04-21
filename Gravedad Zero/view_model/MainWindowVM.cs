using Gravedad_Zero.services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;


namespace Gravedad_Zero.view_model
{
    class MainWindowVM : ObservableObject
    {
        Navegation servicio;

        public RelayCommand Gestion { get; }
        MainWindow mw;

        public MainWindowVM(MainWindow mainWindow)
        {
            servicio = new Navegation();
            Gestion = new RelayCommand(CargarVentenaGestion);
            mw = mainWindow;
        }

        private void CargarVentenaGestion()
        {
            servicio.CargarVentanaGestion();
            mw.Close();
        }
    }
}
