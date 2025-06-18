namespace ContentService.Service.Domain.Entities;

/// <summary>
/// 新闻实体
/// </summary>
public class News
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; } = string.Empty;
}
