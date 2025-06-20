using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 数据权限管理服务接口
/// </summary>
public interface IDataPermService
{
    /// <summary>
    /// 查询单个数据权限
    /// </summary>
    Task<SysDataPermEntity?> GetAsync(long id);

    /// <summary>
    /// 查询数据权限列表
    /// </summary>
    Task<List<SysDataPermEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询数据权限数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增数据权限
    /// </summary>
    Task<int> SaveAsync(SysDataPermEntity entity);

    /// <summary>
    /// 更新数据权限
    /// </summary>
    Task<int> UpdateAsync(SysDataPermEntity entity);

    /// <summary>
    /// 删除数据权限
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除数据权限
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
