using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace FluentRibbonExample
{
    public partial class App : Application
    {
        public App()
        {
            var services = new ServiceCollection();
            Ioc.Default.ConfigureServices(BuildProvider());
        }

        private ServiceProvider BuildProvider()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
