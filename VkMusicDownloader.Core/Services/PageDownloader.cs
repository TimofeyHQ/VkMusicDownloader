using Microsoft.Extensions.Logging;

namespace VkMusicDownloader.Core.Services;

using Interfaces;
using VkMusicDownloader.Core.Models;

public class PageDownloader : IPageDownloader, IDisposable
{
    private readonly ILogger<PageDownloader> _logger;
    private readonly HttpClient _httpClient;

    public PageDownloader(ILogger<PageDownloader> logger,
        HttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;
    }

    public void Dispose() => _httpClient.Dispose();

    public VkPageData DownloadPageData(Uri pageUri)
    {
        throw new NotImplementedException();
    }
}
