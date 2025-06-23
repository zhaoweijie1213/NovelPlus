using System;

namespace NovelPlus.Crawler.Service.Application.Input;

/// <summary>
/// 爬虫源输入
/// </summary>
public class CrawlSourceInput
{
    /// <summary>站点编号</summary>
    public int Id { get; set; }
    /// <summary>站点名称</summary>
    public string SourceName { get; set; } = string.Empty;
    /// <summary>爬虫规则</summary>
    public string CrawlRule { get; set; } = string.Empty;
    /// <summary>站点状态</summary>
    public byte? SourceStatus { get; set; }
    /// <summary>创建时间</summary>
    public DateTime? CreateTime { get; set; }
    /// <summary>更新时间</summary>
    public DateTime? UpdateTime { get; set; }
}
