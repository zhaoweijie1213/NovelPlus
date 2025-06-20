using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 系统日志仓储接口
/// </summary>
public interface ILogRepository
{
    /// <summary>
    /// 查询日志
    /// </summary>
    Task<SysLogEntity?> GetAsync(long id);

    /// <summary>
    /// 查询日志列表
    /// </summary>
    Task<List<SysLogEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询日志数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增日志
    /// </summary>
    Task<int> SaveAsync(SysLogEntity entity);

    /// <summary>
    /// 更新日志
    /// </summary>
    Task<int> UpdateAsync(SysLogEntity entity);

    /// <summary>
    /// 删除日志
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除日志
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
