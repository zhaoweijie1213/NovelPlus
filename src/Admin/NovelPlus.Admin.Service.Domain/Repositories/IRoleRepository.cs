using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 角色管理仓储接口
/// </summary>
public interface IRoleRepository : ITransientDependency
{
    /// <summary>
    /// 查询单个角色
    /// </summary>
    Task<SysRoleEntity?> GetAsync(long id);

    /// <summary>
    /// 查询角色列表
    /// </summary>
    Task<List<SysRoleEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询角色数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增角色
    /// </summary>
    Task<int> SaveAsync(SysRoleEntity entity);

    /// <summary>
    /// 更新角色
    /// </summary>
    Task<int> UpdateAsync(SysRoleEntity entity);

    /// <summary>
    /// 删除角色
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除角色
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
