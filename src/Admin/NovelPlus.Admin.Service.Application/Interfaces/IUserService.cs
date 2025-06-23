using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 用户服务接口
/// </summary>
public interface IUserService : IScopeDependency
{
    /// <summary>
    /// 查询单个用户
    /// </summary>
    Task<UserEntity?> GetAsync(long id);

    /// <summary>
    /// 查询用户列表
    /// </summary>
    Task<List<UserEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询用户数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增用户
    /// </summary>
    Task<int> SaveAsync(UserEntity user);

    /// <summary>
    /// 更新用户
    /// </summary>
    Task<int> UpdateAsync(UserEntity user);

    /// <summary>
    /// 删除用户
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除用户
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    Task<Dictionary<object, object>> TableStaAsync(DateTime minDate);
}
