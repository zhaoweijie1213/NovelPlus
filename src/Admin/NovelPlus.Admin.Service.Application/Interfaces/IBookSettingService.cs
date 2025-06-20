using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 首页小说设置服务接口
/// </summary>
public interface IBookSettingService
{
    Task<BookSettingEntity?> GetAsync(long id);

    Task<List<BookSettingEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(BookSettingEntity setting);

    Task<int> UpdateAsync(BookSettingEntity setting);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
