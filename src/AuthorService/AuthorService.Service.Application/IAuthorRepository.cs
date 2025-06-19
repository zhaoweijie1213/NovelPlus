namespace AuthorService.Service.Application;

using System;
using System.Collections.Generic;
using global::AuthorService.Service.Domain.Entities;

/// <summary>
/// 作家仓储接口
/// </summary>
public interface IAuthorRepository
{
    /// <summary>
    /// 根据ID获取作家
    /// </summary>
    Author? Get(long id);

    /// <summary>
    /// 条件查询作家
    /// </summary>
    IEnumerable<Author> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存作家
    /// </summary>
    int Save(Author author);

    /// <summary>
    /// 更新作家
    /// </summary>
    int Update(Author author);

    /// <summary>
    /// 删除作家
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除作家
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
