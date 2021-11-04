using Autofac;
using EnvVariable.UI.Startup;

namespace EnvVariable.UI.ViewModel
{
    public class ViewModelLocator
    {
        public IMainWindowViewModel MainWindowViewModel => Bootstrapper.Container.Resolve<IMainWindowViewModel>();
        public EnvVariableListViewModel EnvVariableListViewModel => Bootstrapper.Container.Resolve<EnvVariableListViewModel>();
    }
}
