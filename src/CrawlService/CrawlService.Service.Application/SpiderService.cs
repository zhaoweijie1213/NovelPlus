using System.Collections.Generic;
using CrawlService.Service.Domain.Entities;

namespace CrawlService.Service.Application;

/// <summary>
/// 爬虫业务实现
/// </summary>
public class SpiderService : ISpiderService
{
    /// <summary>
    /// 示例任务列表
    /// </summary>
    private readonly List<SpiderTask> _tasks = new()
    {
        new SpiderTask { Id = 1, Url = "https://example.com" }
    };

    /// <inheritdoc />
    public IEnumerable<SpiderTask> GetAll() => _tasks;
}
