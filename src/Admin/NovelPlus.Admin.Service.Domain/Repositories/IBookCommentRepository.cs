using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 小说评论仓储接口
/// </summary>
public interface IBookCommentRepository : ITransientDependency
{
    /// <summary>
    /// 查询评论
    /// </summary>
    Task<BookCommentEntity?> GetAsync(long id);

    /// <summary>
    /// 评论列表
    /// </summary>
    Task<List<BookCommentEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 评论数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增评论
    /// </summary>
    Task<int> SaveAsync(BookCommentEntity comment);

    /// <summary>
    /// 更新评论
    /// </summary>
    Task<int> UpdateAsync(BookCommentEntity comment);

    /// <summary>
    /// 删除评论
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除评论
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
