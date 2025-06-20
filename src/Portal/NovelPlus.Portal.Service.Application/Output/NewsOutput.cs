namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 新闻输出
/// </summary>
public class NewsOutput
{
    public long Id { get; set; }
    public int? CatId { get; set; }
    public string CatName { get; set; } = string.Empty;
    public string SourceName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public long ReadCount { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? CreateUserId { get; set; }
    public DateTime? UpdateTime { get; set; }
    public long? UpdateUserId { get; set; }
}
