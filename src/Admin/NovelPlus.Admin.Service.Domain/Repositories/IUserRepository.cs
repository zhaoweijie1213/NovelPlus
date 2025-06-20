using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 用户仓储接口
/// </summary>
public interface IUserRepository
{
    Task<UserEntity?> GetAsync(long id);

    Task<List<UserEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(UserEntity user);

    Task<int> UpdateAsync(UserEntity user);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);

    Task<Dictionary<object, object>> TableStaAsync(DateTime minDate);
}
