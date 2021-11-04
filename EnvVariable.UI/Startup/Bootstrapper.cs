using Autofac;
using EnvVariable.Data;
using EnvVariable.UI.View;
using EnvVariable.UI.ViewModel;

namespace EnvVariable.UI.Startup
{
    public static class Bootstrapper
    {
        public static IContainer Container { get; private set; }

        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            //views
            builder.RegisterType<MainWindow>().AsSelf();

            //View models
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();
            builder.RegisterType<EnvVariableListViewModel>().AsSelf();

            //Providers
            builder.RegisterType<SimpleProvider>().As<IEnvironmentVariableProvider>();

            Container = builder.Build();
        }
    }
}
