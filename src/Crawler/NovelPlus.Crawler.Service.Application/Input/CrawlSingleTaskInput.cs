using System;

namespace NovelPlus.Crawler.Service.Application.Input;

/// <summary>
/// 单本采集任务输入
/// </summary>
public class CrawlSingleTaskInput
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
