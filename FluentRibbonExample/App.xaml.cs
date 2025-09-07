using CommunityToolkit.Mvvm.DependencyInjection;
using FluentRibbonExample.FluentZen;
using FluentRibbonExample.Service.Http;
using FluentRibbonExample.Zen;
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

            // Register view, viewmodel
            services.AddTransient<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();

            services.AddTransient<ZenControl>();
            services.AddSingleton<ZenViewModel>();

            services.AddTransient<FluentZenWindow>();

            // Register services
            services.AddSingleton<IHttpClient, SystemHttpClient>();

            return services.BuildServiceProvider();
        }
    }
}
