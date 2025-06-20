using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 小说目录服务接口
/// </summary>
public interface IBookIndexService
{
    Task<BookIndexEntity?> GetAsync(long id);

    Task<List<BookIndexEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(BookIndexEntity index);

    Task<int> UpdateAsync(BookIndexEntity index);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
