namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 小说内容输出
/// </summary>
public class BookContentOutput
{
    public long Id { get; set; }
    public long? IndexId { get; set; }
    public string Content { get; set; } = string.Empty;
}
