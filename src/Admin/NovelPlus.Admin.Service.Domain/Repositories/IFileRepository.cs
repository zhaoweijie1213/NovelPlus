using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 文件管理仓储接口
/// </summary>
public interface IFileRepository
{
    /// <summary>
    /// 查询文件
    /// </summary>
    Task<SysFileEntity?> GetAsync(long id);

    /// <summary>
    /// 查询列表
    /// </summary>
    Task<List<SysFileEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增
    /// </summary>
    Task<int> SaveAsync(SysFileEntity entity);

    /// <summary>
    /// 更新
    /// </summary>
    Task<int> UpdateAsync(SysFileEntity entity);

    /// <summary>
    /// 删除
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
