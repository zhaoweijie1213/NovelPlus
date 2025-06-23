using NovelPlus.Portal.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 用户仓储接口
/// </summary>
public interface IUserRepository : ITransientDependency
{
    /// <summary>
    /// 查询用户
    /// </summary>
    /// <param name="id">用户ID</param>
    /// <returns>用户信息</returns>
    Task<UserEntity?> GetAsync(long id);

    /// <summary>
    /// 用户列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>用户集合</returns>
    Task<List<UserEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 用户数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增用户
    /// </summary>
    /// <param name="user">用户实体</param>
    Task<int> SaveAsync(UserEntity user);

    /// <summary>
    /// 更新用户
    /// </summary>
    /// <param name="user">用户实体</param>
    Task<int> UpdateAsync(UserEntity user);

    /// <summary>
    /// 删除用户
    /// </summary>
    /// <param name="id">用户ID</param>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除用户
    /// </summary>
    /// <param name="ids">用户ID集合</param>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 增加用户余额
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <param name="amount">金额</param>
    Task AddUserBalanceAsync(long userId, int amount);
}
