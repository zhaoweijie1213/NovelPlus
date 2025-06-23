using Quartz;
using System.Text.Json;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Services;

namespace NovelPlus.Crawler.Service.Application.Services;

/// <summary>
/// 爬虫作业，用于执行单次小说采集。
/// </summary>
public class CrawlJob : IJob
{
    /// <inheritdoc />
    public async Task Execute(IJobExecutionContext context)
    {
        var parser = (CrawlParser)context.Scheduler.Context.Get("parser")!;
        var ruleJson = context.MergedJobDataMap.GetString("rule");
        var bookId = context.MergedJobDataMap.GetString("bookId");
        if (ruleJson is null || bookId is null)
        {
            return;
        }

        var rule = JsonSerializer.Deserialize<RuleBean>(ruleJson);
        if (rule is null)
        {
            return;
        }

        await parser.ParseBookAsync(rule, bookId);
    }
}
