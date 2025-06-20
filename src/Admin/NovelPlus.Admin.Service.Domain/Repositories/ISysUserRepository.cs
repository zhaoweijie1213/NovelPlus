using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 系统用户仓储接口
/// </summary>
public interface ISysUserRepository
{
    /// <summary>
    /// 查询单个系统用户
    /// </summary>
    Task<SysUserEntity?> GetAsync(long id);

    /// <summary>
    /// 查询系统用户列表
    /// </summary>
    Task<List<SysUserEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询系统用户数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增系统用户
    /// </summary>
    Task<int> SaveAsync(SysUserEntity entity);

    /// <summary>
    /// 更新系统用户
    /// </summary>
    Task<int> UpdateAsync(SysUserEntity entity);

    /// <summary>
    /// 删除系统用户
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除系统用户
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
