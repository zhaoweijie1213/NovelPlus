using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 小说内容服务接口
/// </summary>
public interface IBookContentService
{
    Task<BookContentEntity?> GetAsync(long id);

    Task<List<BookContentEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(BookContentEntity content);

    Task<int> UpdateAsync(BookContentEntity content);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
