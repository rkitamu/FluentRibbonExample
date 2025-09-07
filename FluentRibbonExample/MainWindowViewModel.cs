using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentRibbonExample.Service.Http;

namespace FluentRibbonExample
{
    public partial class MainWindowViewModel: ObservableObject
    {
        private IHttpClient _httpClient;

        public MainWindowViewModel(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [ObservableProperty]
        private string _zen = string.Empty;

        [RelayCommand]
        private async Task FetchZen()
        {
            var res = await _httpClient.GetStringAsync("https://api.github.com/zen");
            Zen = res;
        }
    }
}
