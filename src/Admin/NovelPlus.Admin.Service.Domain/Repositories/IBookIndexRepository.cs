using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 小说目录仓储接口
/// </summary>
public interface IBookIndexRepository
{
    Task<BookIndexEntity?> GetAsync(long id);

    Task<List<BookIndexEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(BookIndexEntity index);

    Task<int> UpdateAsync(BookIndexEntity index);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
