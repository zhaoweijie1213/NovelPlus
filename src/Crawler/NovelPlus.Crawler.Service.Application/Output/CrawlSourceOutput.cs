using System;

namespace NovelPlus.Crawler.Service.Application.Output;

/// <summary>
/// 爬虫源输出
/// </summary>
public class CrawlSourceOutput
{
    public int Id { get; set; }
    public string SourceName { get; set; } = string.Empty;
    public string CrawlRule { get; set; } = string.Empty;
    public byte? SourceStatus { get; set; }
    public DateTime? CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
}
