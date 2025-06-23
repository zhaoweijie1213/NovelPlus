using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Application.Interfaces;

/// <summary>
/// 章节内容服务接口
/// </summary>
public interface IBookContentService : IScopeDependency
{
    /// <summary>
    /// 查询章节内容
    /// </summary>
    Task<BookContentEntity?> QueryBookContentAsync(long bookId, long bookIndexId);
}
