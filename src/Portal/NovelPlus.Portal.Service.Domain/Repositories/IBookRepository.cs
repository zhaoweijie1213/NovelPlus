using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 小说表仓储接口
/// </summary>
public interface IBookRepository
{
    /// <summary>
    /// 查询单本小说
    /// </summary>
    /// <param name="id">小说ID</param>
    /// <returns>小说信息</returns>
    Task<BookEntity?> GetAsync(long id);

    /// <summary>
    /// 查询小说列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>小说集合</returns>
    Task<List<BookEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询小说数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>小说数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增小说
    /// </summary>
    /// <param name="book">小说实体</param>
    Task<int> SaveAsync(BookEntity book);

    /// <summary>
    /// 更新小说
    /// </summary>
    /// <param name="book">小说实体</param>
    Task<int> UpdateAsync(BookEntity book);

    /// <summary>
    /// 删除小说
    /// </summary>
    /// <param name="id">小说ID</param>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除小说
    /// </summary>
    /// <param name="ids">小说ID集合</param>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 分页搜索小说
    /// </summary>
    /// <param name="query">搜索参数</param>
    /// <returns>小说集合</returns>
    Task<List<BookEntity>> SearchByPageAsync(Dictionary<string, object> query);

    /// <summary>
    /// 增加点击量
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <param name="visitCount">增加的点击量</param>
    Task AddVisitCountAsync(long bookId, int visitCount);

    /// <summary>
    /// 查询同分类推荐小说
    /// </summary>
    /// <param name="catId">分类ID</param>
    /// <returns>小说集合</returns>
    Task<List<BookEntity>> ListRecBookByCatIdAsync(int catId);

    /// <summary>
    /// 增加评论数
    /// </summary>
    /// <param name="bookId">小说ID</param>
    Task AddCommentCountAsync(long bookId);

    /// <summary>
    /// 查询包含网络图片的小说
    /// </summary>
    /// <param name="localPicPrefix">本地图片前缀</param>
    /// <param name="limit">查询条数</param>
    /// <returns>小说集合</returns>
    Task<List<BookEntity>> QueryNetworkPicBooksAsync(string localPicPrefix, int limit);

    /// <summary>
    /// 按评分随机查询小说
    /// </summary>
    /// <param name="limit">查询条数</param>
    /// <returns>小说集合</returns>
    Task<List<BookEntity>> SelectIdsByScoreAndRandomAsync(int limit);
}
