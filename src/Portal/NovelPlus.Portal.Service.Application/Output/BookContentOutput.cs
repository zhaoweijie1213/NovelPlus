namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 小说内容输出
/// </summary>
public class BookContentOutput
{
    /// <summary>
    /// 内容编号
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 目录编号
    /// </summary>
    public long? IndexId { get; set; }

    /// <summary>
    /// 正文内容
    /// </summary>
    public string Content { get; set; } = string.Empty;
}
