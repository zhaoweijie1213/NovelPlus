namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 新闻输出
/// </summary>
public class NewsOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 分类编号
    /// </summary>
    public int? CatId { get; set; }

    /// <summary>
    /// 分类名称
    /// </summary>
    public string CatName { get; set; } = string.Empty;

    /// <summary>
    /// 来源名称
    /// </summary>
    public string SourceName { get; set; } = string.Empty;

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 阅读数
    /// </summary>
    public long ReadCount { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 更新人
    /// </summary>
    public long? UpdateUserId { get; set; }
}
