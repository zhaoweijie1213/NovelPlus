namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 用户反馈输出
/// </summary>
public class UserFeedbackOutput
{
    /// <summary>
    /// 反馈编号
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 用户编号
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// 反馈内容
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 提交时间
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
