using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using FluentRibbonExample.ControlNestedFluentZen;
using FluentRibbonExample.FluentZen;

namespace FluentRibbonExample
{
    public partial class MainWindowViewModel
    {
        [RelayCommand]
        private void NavigateToZen()
        {
            // TDOO: Navigation Logic
            var window = Ioc.Default.GetRequiredService<ControlNestedFluentZenWindow>();
            window.Show();
        }

        [RelayCommand]
        private void NavigateToZenAsNewWindow()
        {
            // TDOO: Navigation Logic
            var window = Ioc.Default.GetRequiredService<FluentZenWindow>();
            window.Show();
        }
    }
}
