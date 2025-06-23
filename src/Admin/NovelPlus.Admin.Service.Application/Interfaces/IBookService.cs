using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 小说表服务接口
/// </summary>
public interface IBookService : IScopeDependency
{
    /// <summary>
    /// 查询单本小说
    /// </summary>
    Task<BookEntity?> GetAsync(long id);

    /// <summary>
    /// 查询小说列表
    /// </summary>
    Task<List<BookEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询小说数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增小说
    /// </summary>
    Task<int> SaveAsync(BookEntity book);

    /// <summary>
    /// 更新小说
    /// </summary>
    Task<int> UpdateAsync(BookEntity book);

    /// <summary>
    /// 删除小说
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除小说
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    Task<Dictionary<object, object>> TableStaAsync(DateTime minDate);
}
