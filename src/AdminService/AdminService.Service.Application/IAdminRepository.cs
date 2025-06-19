namespace AdminService.Service.Application;

using System;
using System.Collections.Generic;
using global::AdminService.Service.Domain.Entities;

/// <summary>
/// 管理员仓储接口
/// </summary>
public interface IAdminRepository
{
    /// <summary>
    /// 根据ID获取管理员
    /// </summary>
    AdminUser? Get(long id);

    /// <summary>
    /// 条件查询管理员
    /// </summary>
    IEnumerable<AdminUser> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存管理员
    /// </summary>
    int Save(AdminUser admin);

    /// <summary>
    /// 更新管理员
    /// </summary>
    int Update(AdminUser admin);

    /// <summary>
    /// 删除管理员
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除管理员
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
