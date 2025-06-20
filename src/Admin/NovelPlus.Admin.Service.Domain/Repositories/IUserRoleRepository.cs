using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 用户角色关系仓储接口
/// </summary>
public interface IUserRoleRepository
{
    /// <summary>
    /// 查询单条记录
    /// </summary>
    Task<SysUserRoleEntity?> GetAsync(long id);

    /// <summary>
    /// 查询列表
    /// </summary>
    Task<List<SysUserRoleEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增
    /// </summary>
    Task<int> SaveAsync(SysUserRoleEntity entity);

    /// <summary>
    /// 更新
    /// </summary>
    Task<int> UpdateAsync(SysUserRoleEntity entity);

    /// <summary>
    /// 删除
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
