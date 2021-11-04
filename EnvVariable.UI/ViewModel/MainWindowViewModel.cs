using Autofac;
using EnvVariable.Data;
using EnvVariable.UI.Startup;

namespace EnvVariable.UI.ViewModel
{
    public class MainWindowViewModel : ObservableViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel()
        {
        }

        public EnvVariableListViewModel EnvVariableListViewModel => Bootstrapper.Container.Resolve<EnvVariableListViewModel>();
    }
}
