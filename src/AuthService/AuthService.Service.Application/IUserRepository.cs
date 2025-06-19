namespace AuthService.Service.Application;

using System;
using System.Collections.Generic;
using global::AuthService.Service.Domain.Entities;

/// <summary>
/// 用户仓储接口
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// 根据ID获取用户
    /// </summary>
    User? Get(long id);

    /// <summary>
    /// 条件查询用户
    /// </summary>
    IEnumerable<User> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存用户
    /// </summary>
    int Save(User user);

    /// <summary>
    /// 更新用户
    /// </summary>
    int Update(User user);

    /// <summary>
    /// 删除用户
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除用户
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
