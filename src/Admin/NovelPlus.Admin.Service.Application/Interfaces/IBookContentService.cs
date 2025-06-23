using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 小说内容服务接口
/// </summary>
public interface IBookContentService : IScopeDependency
{
    /// <summary>
    /// 查询单章内容
    /// </summary>
    Task<BookContentEntity?> GetAsync(long id);

    /// <summary>
    /// 查询章节内容列表
    /// </summary>
    Task<List<BookContentEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询内容数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增章节内容
    /// </summary>
    Task<int> SaveAsync(BookContentEntity content);

    /// <summary>
    /// 更新章节内容
    /// </summary>
    Task<int> UpdateAsync(BookContentEntity content);

    /// <summary>
    /// 删除章节内容
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除章节内容
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
