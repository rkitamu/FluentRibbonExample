using System.Net.Http;

namespace FluentRibbonExample.Service.Http
{
    class SystemHttpClient : IHttpClient
    {
        private readonly HttpClient _httpClient = new();

        public SystemHttpClient()
        {
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("FluentRibbonExample/1.0");
        }

        public async Task<string> GetStringAsync(string requestUri, CancellationToken cancellationToken = default)
        {
            using var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
