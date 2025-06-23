using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 章节内容仓储接口
/// </summary>
public interface IBookContentRepository : ITransientDependency
{
    /// <summary>
    /// 根据书籍和章节查询内容
    /// </summary>
    Task<BookContentEntity?> GetByBookAndIndexAsync(long bookId, long bookIndexId);
}
