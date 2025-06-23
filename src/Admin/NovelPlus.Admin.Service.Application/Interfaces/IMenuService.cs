using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 菜单管理服务接口
/// </summary>
public interface IMenuService : IScopeDependency
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
