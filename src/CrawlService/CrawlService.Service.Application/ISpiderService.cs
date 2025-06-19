using System;
using System.Collections.Generic;
using CrawlService.Service.Domain.Entities;

namespace CrawlService.Service.Application;

/// <summary>
/// 爬虫业务接口
/// </summary>
public interface ISpiderService
{
    /// <summary>
    /// 获取全部爬虫任务
    /// </summary>
    IEnumerable<SpiderTask> GetAll();

    /// <summary>
    /// 根据ID获取任务
    /// </summary>
    SpiderTask? GetById(long id);

    /// <summary>
    /// 条件查询任务
    /// </summary>
    IEnumerable<SpiderTask> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存任务
    /// </summary>
    int Save(SpiderTask task);

    /// <summary>
    /// 更新任务
    /// </summary>
    int Update(SpiderTask task);

    /// <summary>
    /// 删除任务
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除任务
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
