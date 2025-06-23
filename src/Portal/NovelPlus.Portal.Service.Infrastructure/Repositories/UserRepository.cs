using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// UserRepository 实现
/// </summary>
public class UserRepository(ILogger<UserRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<UserEntity>(logger, options), IUserRepository
{
    /// <summary>
    /// 查询用户
    /// </summary>
    /// <param name="id">用户ID</param>
    /// <returns>用户信息</returns>
    public Task<UserEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 用户列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>用户集合</returns>
    public Task<List<UserEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 用户数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增用户
    /// </summary>
    /// <param name="user">用户实体</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(UserEntity user) => SaveAsyncInternal(user);

    /// <summary>
    /// 更新用户
    /// </summary>
    /// <param name="user">用户实体</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(UserEntity user) => UpdateAsyncInternal(user);

    /// <summary>
    /// 删除用户
    /// </summary>
    /// <param name="id">用户ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除用户
    /// </summary>
    /// <param name="ids">用户ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids) => BatchRemoveAsyncInternal(ids);

    /// <summary>
    /// 增加用户余额
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <param name="amount">金额</param>
    public Task AddUserBalanceAsync(long userId, int amount)
    {
        return Db.Updateable<UserEntity>()
            .SetColumns(i => i.AccountBalance == i.AccountBalance + amount)
            .Where(i => i.Id == userId)
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 判断用户名是否已存在
    /// </summary>
    /// <param name="username">用户名</param>
    /// <returns>存在返回 true</returns>
    public Task<bool> ExistsUserNameAsync(string username)
    {
        return Db.Queryable<UserEntity>().Where(i => i.Username == username).AnyAsync();
    }

    /// <summary>
    /// 根据用户名密码查询用户
    /// </summary>
    /// <param name="username">用户名</param>
    /// <param name="password">密码</param>
    /// <returns>用户实体或 null</returns>
    public async Task<UserEntity?> GetByNameAndPasswordAsync(string username, string password)
    {
        return await Db.Queryable<UserEntity>()
            .Where(i => i.Username == username && i.Password == password)
            .FirstAsync();
    }
}
