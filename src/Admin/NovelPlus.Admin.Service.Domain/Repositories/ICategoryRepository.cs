using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 新闻类别仓储接口
/// </summary>
public interface ICategoryRepository : ITransientDependency
{
    /// <summary>
    /// 查询类别
    /// </summary>
    Task<CategoryEntity?> GetAsync(int id);

    /// <summary>
    /// 查询列表
    /// </summary>
    Task<List<CategoryEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增
    /// </summary>
    Task<int> SaveAsync(CategoryEntity category);

    /// <summary>
    /// 更新
    /// </summary>
    Task<int> UpdateAsync(CategoryEntity category);

    /// <summary>
    /// 删除
    /// </summary>
    Task<int> RemoveAsync(int id);

    /// <summary>
    /// 批量删除
    /// </summary>
    Task<int> BatchRemoveAsync(int[] ids);
}
