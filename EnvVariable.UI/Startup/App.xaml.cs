using System.Windows;
using Autofac;
using EnvVariable.UI.View;
using EnvVariable.UI.ViewModel;

namespace EnvVariable.UI.Startup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstrapper.Initialize();
            var mainWindow = Bootstrapper.Container.Resolve<MainWindow>();
            mainWindow.DataContext = Bootstrapper.Container.Resolve<IMainWindowViewModel>();

            mainWindow.Show();
        }
    }
}
