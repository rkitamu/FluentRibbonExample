using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using FluentRibbonExample.FluentZen;

namespace FluentRibbonExample
{
    public partial class MainWindowViewModel
    {
        [RelayCommand]
        private void NavigateToZen()
        {
            // めんどかった
        }

        [RelayCommand]
        private void NavigateToZenAsNewWindow()
        {
            // TDOO: Navigation Logic
            var window = Ioc.Default.GetRequiredService<FluentZenWindow>();
            window.ShowDialog();
        }
    }
}
