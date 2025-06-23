using NovelPlus.Portal.Service.Application.Interfaces;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 文件服务实现
/// </summary>
public class FileService : IFileService
{
    /// <inheritdoc/>
    public async Task<string> TransFileAsync(string picSrc, string picSavePath)
    {
        using var http = new HttpClient();
        var bytes = await http.GetByteArrayAsync(picSrc);
        var fileName = Path.GetFileName(new Uri(picSrc).LocalPath);
        var savePath = Path.Combine(picSavePath, fileName);
        await File.WriteAllBytesAsync(savePath, bytes);
        return savePath;
    }
}
