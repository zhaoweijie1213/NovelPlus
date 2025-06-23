namespace NovelPlus.Crawler.Service.Domain.Config;

/// <summary>
/// 爬虫配置选项
/// </summary>
public class CrawlOptions
{
    /// <summary>最小请求间隔(毫秒)</summary>
    public int IntervalMin { get; set; } = 300;
    /// <summary>最大请求间隔(毫秒)</summary>
    public int IntervalMax { get; set; } = 500;
    /// <summary>最大重试次数</summary>
    public int RetryCount { get; set; } = 3;
    /// <summary>无效页面最小长度</summary>
    public int InvalidHtmlLength { get; set; } = 1500;
}
