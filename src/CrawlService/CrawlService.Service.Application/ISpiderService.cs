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
}
