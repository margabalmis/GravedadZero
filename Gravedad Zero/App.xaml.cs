
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Gravedad_Zero
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly IHost _host;
        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    //string firebaseApiContext = context.Configuration.GetValue<string>("FIREBASE_API_KEY");

                    string firebaseApiContext = "AIzaSyAqd6QdSMSgl1K7-Kt3h7JoQQi8xmtxiFU";

                    //FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(firebaseApiContext);

                    service.AddSingleton<MainWindow>((services) => new MainWindow());
                })
                .Build();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }

    }
}
