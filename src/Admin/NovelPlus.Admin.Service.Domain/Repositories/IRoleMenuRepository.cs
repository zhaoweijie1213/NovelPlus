using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 角色菜单关系仓储接口
/// </summary>
public interface IRoleMenuRepository : ITransientDependency
{
    /// <summary>
    /// 查询单条记录
    /// </summary>
    Task<SysRoleMenuEntity?> GetAsync(long id);

    /// <summary>
    /// 查询列表
    /// </summary>
    Task<List<SysRoleMenuEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增
    /// </summary>
    Task<int> SaveAsync(SysRoleMenuEntity entity);

    /// <summary>
    /// 更新
    /// </summary>
    Task<int> UpdateAsync(SysRoleMenuEntity entity);

    /// <summary>
    /// 删除
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
