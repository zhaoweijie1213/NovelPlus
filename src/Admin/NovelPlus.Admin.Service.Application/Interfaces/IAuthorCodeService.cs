using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 作家邀请码表服务接口
/// </summary>
public interface IAuthorCodeService
{
    /// <summary>
    /// 查询单个邀请码
    /// </summary>
    Task<AuthorCodeEntity?> GetAsync(long id);

    /// <summary>
    /// 查询邀请码列表
    /// </summary>
    Task<List<AuthorCodeEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询邀请码数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增邀请码
    /// </summary>
    Task<int> SaveAsync(AuthorCodeEntity authorCode);

    /// <summary>
    /// 更新邀请码
    /// </summary>
    Task<int> UpdateAsync(AuthorCodeEntity authorCode);

    /// <summary>
    /// 删除邀请码
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除邀请码
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
