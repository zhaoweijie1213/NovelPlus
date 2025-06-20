using System;

namespace NovelPlus.Crawler.Service.Application.Output;

/// <summary>
/// 单本采集任务输出
/// </summary>
public class CrawlSingleTaskOutput
{
    public long Id { get; set; }
    public int? SourceId { get; set; }
    public string SourceName { get; set; } = string.Empty;
    public string SourceBookId { get; set; } = string.Empty;
    public int? CatId { get; set; }
    public string BookName { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public byte? TaskStatus { get; set; }
    public byte? ExcCount { get; set; }
    public DateTime? CreateTime { get; set; }
}
