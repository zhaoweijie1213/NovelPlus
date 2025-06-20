using System;

namespace NovelPlus.Crawler.Service.Application.Input;

/// <summary>
/// 爬虫源输入
/// </summary>
public class CrawlSourceInput
{
    public int Id { get; set; }
    public string SourceName { get; set; } = string.Empty;
    public string CrawlRule { get; set; } = string.Empty;
    public byte? SourceStatus { get; set; }
    public DateTime? CreateTime { get; set; }
    public DateTime? UpdateTime { get; set; }
}
