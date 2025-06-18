namespace CrawlService.Service.Domain.Entities;

/// <summary>
/// 爬虫任务实体
/// </summary>
public class SpiderTask
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 目标地址
    /// </summary>
    public string Url { get; set; } = string.Empty;
}
