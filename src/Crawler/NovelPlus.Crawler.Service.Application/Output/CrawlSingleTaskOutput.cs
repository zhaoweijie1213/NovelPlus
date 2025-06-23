using System;

namespace NovelPlus.Crawler.Service.Application.Output;

/// <summary>
/// 单本采集任务输出
/// </summary>
public class CrawlSingleTaskOutput
{
    /// <summary>任务编号</summary>
    public long Id { get; set; }
    /// <summary>来源站点编号</summary>
    public int? SourceId { get; set; }
    /// <summary>来源站点名称</summary>
    public string SourceName { get; set; } = string.Empty;
    /// <summary>站点书籍编号</summary>
    public string SourceBookId { get; set; } = string.Empty;
    /// <summary>分类编号</summary>
    public int? CatId { get; set; }
    /// <summary>小说名称</summary>
    public string BookName { get; set; } = string.Empty;
    /// <summary>作者名称</summary>
    public string AuthorName { get; set; } = string.Empty;
    /// <summary>任务状态</summary>
    public byte? TaskStatus { get; set; }
    /// <summary>异常次数</summary>
    public byte? ExcCount { get; set; }
    /// <summary>创建时间</summary>
    public DateTime? CreateTime { get; set; }
}
