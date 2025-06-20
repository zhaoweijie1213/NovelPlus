using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 小说评论仓储接口
/// </summary>
public interface IBookCommentRepository
{
    /// <summary>
    /// 查询评论
    /// </summary>
    /// <param name="id">评论ID</param>
    /// <returns>评论信息</returns>
    Task<BookCommentEntity?> GetAsync(long id);

    /// <summary>
    /// 评论列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>评论集合</returns>
    Task<List<BookCommentEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 评论数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增评论
    /// </summary>
    /// <param name="comment">评论实体</param>
    Task<int> SaveAsync(BookCommentEntity comment);

    /// <summary>
    /// 更新评论
    /// </summary>
    /// <param name="comment">评论实体</param>
    Task<int> UpdateAsync(BookCommentEntity comment);

    /// <summary>
    /// 删除评论
    /// </summary>
    /// <param name="id">评论ID</param>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除评论
    /// </summary>
    /// <param name="ids">评论ID集合</param>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 分页查询评论
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <param name="bookId">小说ID</param>
    /// <returns>评论集合</returns>
    Task<List<BookCommentEntity>> ListCommentByPageAsync(long? userId, long? bookId);
}
