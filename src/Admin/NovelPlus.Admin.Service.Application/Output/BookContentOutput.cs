namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 小说内容输出
/// </summary>
public class BookContentOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 目录ID
    /// </summary>
    public long? IndexId { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; } = string.Empty;
}
