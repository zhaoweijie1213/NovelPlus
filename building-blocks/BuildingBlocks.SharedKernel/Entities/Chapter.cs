namespace BuildingBlocks.SharedKernel.Entities;

/// <summary>
/// 章节实体
/// </summary>
public class Chapter
{
    /// <summary>
    /// 主键ID
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 所属小说ID
    /// </summary>
    public long BookId { get; set; }

    /// <summary>
    /// 章节标题
    /// </summary>
    public string Title { get; set; } = string.Empty;
}
