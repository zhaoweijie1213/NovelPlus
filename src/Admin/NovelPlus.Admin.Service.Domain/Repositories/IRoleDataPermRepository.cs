using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 角色数据权限仓储接口
/// </summary>
public interface IRoleDataPermRepository : ITransientDependency
{
    /// <summary>
    /// 查询单个记录
    /// </summary>
    Task<SysRoleDataPermEntity?> GetAsync(long id);

    /// <summary>
    /// 查询列表
    /// </summary>
    Task<List<SysRoleDataPermEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增
    /// </summary>
    Task<int> SaveAsync(SysRoleDataPermEntity entity);

    /// <summary>
    /// 更新
    /// </summary>
    Task<int> UpdateAsync(SysRoleDataPermEntity entity);

    /// <summary>
    /// 删除
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
