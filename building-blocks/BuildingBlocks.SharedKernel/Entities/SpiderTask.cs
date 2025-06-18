namespace BuildingBlocks.SharedKernel.Entities;

/// <summary>
/// 爬虫任务实体
/// </summary>
public class SpiderTask
{
    /// <summary>
    /// 任务ID
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 目标地址
    /// </summary>
    public string TargetUrl { get; set; } = string.Empty;
}
