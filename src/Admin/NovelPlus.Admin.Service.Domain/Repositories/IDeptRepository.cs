using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 部门管理仓储接口
/// </summary>
public interface IDeptRepository : ITransientDependency
{
    /// <summary>
    /// 查询单个部门
    /// </summary>
    Task<SysDeptEntity?> GetAsync(long id);

    /// <summary>
    /// 查询部门列表
    /// </summary>
    Task<List<SysDeptEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询部门数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增部门
    /// </summary>
    Task<int> SaveAsync(SysDeptEntity entity);

    /// <summary>
    /// 更新部门
    /// </summary>
    Task<int> UpdateAsync(SysDeptEntity entity);

    /// <summary>
    /// 删除部门
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除部门
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
