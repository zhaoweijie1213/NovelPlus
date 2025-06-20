using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 用户服务接口
/// </summary>
public interface IUserService
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
