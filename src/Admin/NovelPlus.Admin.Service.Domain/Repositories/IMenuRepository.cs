using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 菜单管理仓储接口
/// </summary>
public interface IMenuRepository
{
    /// <summary>
    /// 查询单个菜单
    /// </summary>
    Task<SysMenuEntity?> GetAsync(long id);

    /// <summary>
    /// 查询菜单列表
    /// </summary>
    Task<List<SysMenuEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询菜单数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增菜单
    /// </summary>
    Task<int> SaveAsync(SysMenuEntity entity);

    /// <summary>
    /// 更新菜单
    /// </summary>
    Task<int> UpdateAsync(SysMenuEntity entity);

    /// <summary>
    /// 删除菜单
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除菜单
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
