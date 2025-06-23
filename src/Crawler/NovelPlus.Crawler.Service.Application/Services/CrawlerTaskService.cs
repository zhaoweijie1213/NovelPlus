using System.Collections.Concurrent;
using System.Threading;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Services;
using QYQ.Base.Common.IOCExtensions;

namespace NovelPlus.Crawler.Service.Application.Services;

/// <summary>
/// 简单的爬虫任务服务，使用线程执行采集任务。
/// </summary>
public class CrawlerTaskService(CrawlParser parser) : IScopeDependency
{
    /// <summary>解析器实例</summary>
    private readonly CrawlParser _parser = parser;
    /// <summary>任务取消源集合</summary>
    private readonly ConcurrentDictionary<string, CancellationTokenSource> _tokens = new();

    /// <summary>
    /// 启动一个新的爬虫任务。
    /// </summary>
    /// <param name="taskId">任务标识</param>
    /// <param name="rule">解析规则</param>
    /// <param name="bookId">站点书籍编号</param>
    public Task StartTaskAsync(string taskId, RuleBean rule, string bookId)
    {
        var cts = new CancellationTokenSource();
        _tokens[taskId] = cts;

        var thread = new Thread(() =>
        {
            try
            {
                _parser.ParseBookAsync(rule, bookId).GetAwaiter().GetResult();
            }
            catch (OperationCanceledException)
            {
                // 任务被取消
            }
        })
        {
            IsBackground = true
        };

        thread.Start();
        return Task.CompletedTask;
    }

    /// <summary>
    /// 停止指定任务。
    /// </summary>
    /// <param name="taskId">任务标识</param>
    public void StopTask(string taskId)
    {
        if (_tokens.TryRemove(taskId, out var cts))
        {
            cts.Cancel();
        }
    }
}
