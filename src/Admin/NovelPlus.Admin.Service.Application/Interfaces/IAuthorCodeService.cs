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
    Task<AuthorCodeEntity?> GetAsync(long id);

    Task<List<AuthorCodeEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(AuthorCodeEntity authorCode);

    Task<int> UpdateAsync(AuthorCodeEntity authorCode);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
