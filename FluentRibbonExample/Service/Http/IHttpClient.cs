namespace FluentRibbonExample.Service.Http
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string requestUri, CancellationToken cancellationToken = default);
    }
}