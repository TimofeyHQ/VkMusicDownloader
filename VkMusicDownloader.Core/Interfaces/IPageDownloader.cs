namespace VkMusicDownloader.Core.Interfaces;

using Models;

public interface IPageDownloader
{
    public VkPageData DownloadPageData(Uri pageUri);
}
