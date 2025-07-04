using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 文件服务接口
/// </summary>
public interface IFileService
{
    /// <summary>
    /// 转存网络图片
    /// </summary>
    Task<string> TransFileAsync(string picSrc, string picSavePath);
}
