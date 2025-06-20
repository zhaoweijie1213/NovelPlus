using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 小说评论仓储接口
/// </summary>
public interface IBookCommentRepository
{
    Task<BookCommentEntity?> GetAsync(long id);

    Task<List<BookCommentEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(BookCommentEntity comment);

    Task<int> UpdateAsync(BookCommentEntity comment);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
