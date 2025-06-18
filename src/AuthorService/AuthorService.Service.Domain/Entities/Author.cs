namespace AuthorService.Service.Domain.Entities;

/// <summary>
/// 作家实体
/// </summary>
public class Author
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 笔名
    /// </summary>
    public string PenName { get; set; } = string.Empty;
}
