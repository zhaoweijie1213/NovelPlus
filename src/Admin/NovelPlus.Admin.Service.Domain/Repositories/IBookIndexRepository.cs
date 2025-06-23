using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 小说目录仓储接口
/// </summary>
public interface IBookIndexRepository : ITransientDependency
{
    /// <summary>
    /// 查询目录
    /// </summary>
    Task<BookIndexEntity?> GetAsync(long id);

    /// <summary>
    /// 目录列表
    /// </summary>
    Task<List<BookIndexEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 目录数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增目录
    /// </summary>
    Task<int> SaveAsync(BookIndexEntity index);

    /// <summary>
    /// 更新目录
    /// </summary>
    Task<int> UpdateAsync(BookIndexEntity index);

    /// <summary>
    /// 删除目录
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除目录
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
