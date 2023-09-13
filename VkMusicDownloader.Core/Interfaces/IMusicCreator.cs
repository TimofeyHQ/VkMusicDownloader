namespace VkMusicDownloader.Core.Interfaces;

using Models;

internal interface IMusicCreator
{
    public IEnumerable<Stream> CreateMusicFileStream(VkPostData data);
}
