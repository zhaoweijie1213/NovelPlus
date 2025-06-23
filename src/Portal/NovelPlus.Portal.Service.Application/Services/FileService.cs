using NovelPlus.Portal.Service.Application.Interfaces;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 文件服务实现
/// </summary>
public class FileService : IFileService
{
    /// <summary>
    /// 下载并保存远程文件
    /// </summary>
    /// <param name="picSrc">源文件地址</param>
    /// <param name="picSavePath">本地保存目录</param>
    /// <returns>保存后的文件路径</returns>
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
