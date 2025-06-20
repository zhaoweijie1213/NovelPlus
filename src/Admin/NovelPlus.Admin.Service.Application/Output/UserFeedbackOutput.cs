namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 用户反馈输出
/// </summary>
public class UserFeedbackOutput
{
    public long Id { get; set; }
    public long? UserId { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime? CreateTime { get; set; }
}
