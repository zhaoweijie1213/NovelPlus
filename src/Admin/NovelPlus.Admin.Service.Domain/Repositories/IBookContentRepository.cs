using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 小说内容仓储接口
/// </summary>
public interface IBookContentRepository
{
    /// <summary>
    /// 查询章节内容
    /// </summary>
    Task<BookContentEntity?> GetAsync(long id);

    /// <summary>
    /// 内容列表
    /// </summary>
    Task<List<BookContentEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 内容数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增内容
    /// </summary>
    Task<int> SaveAsync(BookContentEntity content);

    /// <summary>
    /// 更新内容
    /// </summary>
    Task<int> UpdateAsync(BookContentEntity content);

    /// <summary>
    /// 删除内容
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除内容
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
