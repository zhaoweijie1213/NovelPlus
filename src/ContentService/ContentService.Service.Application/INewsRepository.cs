namespace ContentService.Service.Application;

using System;
using System.Collections.Generic;
using global::ContentService.Service.Domain.Entities;

/// <summary>
/// 新闻仓储接口
/// </summary>
public interface INewsRepository
{
    /// <summary>
    /// 根据ID获取新闻
    /// </summary>
    News? Get(long id);

    /// <summary>
    /// 条件查询新闻
    /// </summary>
    IEnumerable<News> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存新闻
    /// </summary>
    int Save(News news);

    /// <summary>
    /// 更新新闻
    /// </summary>
    int Update(News news);

    /// <summary>
    /// 删除新闻
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除新闻
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
