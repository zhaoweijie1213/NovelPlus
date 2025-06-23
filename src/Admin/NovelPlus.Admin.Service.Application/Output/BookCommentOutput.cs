namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 小说评论输出
/// </summary>
public class BookCommentOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 小说ID
    /// </summary>
    public long? BookId { get; set; }

    /// <summary>
    /// 评论内容
    /// </summary>
    public string CommentContent { get; set; } = string.Empty;

    /// <summary>
    /// 回复数量
    /// </summary>
    public int? ReplyCount { get; set; }

    /// <summary>
    /// 审核状态
    /// </summary>
    public byte? AuditStatus { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    public long? CreateUserId { get; set; }
}
