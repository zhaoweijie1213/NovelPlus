using System;
using System.Collections.Generic;
using System.Linq;
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

    /// <inheritdoc />
    public SpiderTask? GetById(long id) => _tasks.FirstOrDefault(t => t.Id == id);

    /// <inheritdoc />
    public IEnumerable<SpiderTask> List(IDictionary<string, object> filters) => _tasks;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _tasks.Count;

    /// <inheritdoc />
    public int Save(SpiderTask task)
    {
        task.Id = _tasks.Max(t => t.Id) + 1;
        _tasks.Add(task);
        return 1;
    }

    /// <inheritdoc />
    public int Update(SpiderTask task)
    {
        var index = _tasks.FindIndex(t => t.Id == task.Id);
        if (index == -1) return 0;
        _tasks[index] = task;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return 0;
        _tasks.Remove(task);
        return 1;
    }

    /// <inheritdoc />
    public int BatchRemove(long[] ids)
    {
        var removed = 0;
        foreach (var id in ids) removed += Remove(id);
        return removed;
    }

    /// <inheritdoc />
    public IDictionary<object, object> TableStat(DateTime minDate)
    {
        return new Dictionary<object, object>();
    }
}
