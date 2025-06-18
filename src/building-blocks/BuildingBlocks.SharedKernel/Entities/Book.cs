namespace BuildingBlocks.SharedKernel.Entities;

/// <summary>
/// 小说实体
/// </summary>
public class Book
{
    /// <summary>
    /// 主键ID
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 小说名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 作者ID
    /// </summary>
    public long AuthorId { get; set; }
}
