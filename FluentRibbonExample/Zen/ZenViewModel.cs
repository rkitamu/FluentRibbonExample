using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentRibbonExample.Service.Http;

namespace FluentRibbonExample.Zen
{
    public partial class ZenViewModel : ObservableObject
    {
        private IHttpClient _httpClient;

        public ZenViewModel(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [ObservableProperty]
        private string _zen = string.Empty;

        [RelayCommand]
        private async Task FetchZen()
        {
            Zen = await _httpClient.GetStringAsync("https://api.github.com/zen");
        }
    }
}
