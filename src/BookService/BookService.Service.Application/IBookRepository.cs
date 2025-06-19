namespace BookService.Service.Application;

using System;
using System.Collections.Generic;
using global::BookService.Service.Domain.Entities;

/// <summary>
/// 书籍仓储接口
/// </summary>
public interface IBookRepository
{
    /// <summary>
    /// 根据ID获取书籍
    /// </summary>
    Book? Get(long id);

    /// <summary>
    /// 条件查询书籍
    /// </summary>
    IEnumerable<Book> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存书籍
    /// </summary>
    int Save(Book book);

    /// <summary>
    /// 更新书籍
    /// </summary>
    int Update(Book book);

    /// <summary>
    /// 删除书籍
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除书籍
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
