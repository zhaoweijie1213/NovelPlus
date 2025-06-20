namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 小说评论输出
/// </summary>
public class BookCommentOutput
{
    public long Id { get; set; }
    public long? BookId { get; set; }
    public string CommentContent { get; set; } = string.Empty;
    public int? ReplyCount { get; set; }
    public byte? AuditStatus { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? CreateUserId { get; set; }
}
