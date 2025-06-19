using System;
using System.Collections.Generic;
using ContentService.Service.Domain.Entities;

namespace ContentService.Service.Application;

/// <summary>
/// 内容业务接口
/// </summary>
public interface IContentService
{
    /// <summary>
    /// 获取全部新闻
    /// </summary>
    IEnumerable<News> GetAll();

    /// <summary>
    /// 根据ID获取新闻
    /// </summary>
    News? GetById(long id);

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
