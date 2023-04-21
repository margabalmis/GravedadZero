using Gravedad_Zero.view_model;
using System.Windows;


namespace Gravedad_Zero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM(this);
            this.DataContext = vm;
        }
    }
}
