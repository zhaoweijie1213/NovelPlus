namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 作家邀请码输出
/// </summary>
public class AuthorCodeOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 邀请码
    /// </summary>
    public string InviteCode { get; set; } = string.Empty;

    /// <summary>
    /// 有效时间
    /// </summary>
    public DateTime? ValidityTime { get; set; }

    /// <summary>
    /// 是否已使用
    /// </summary>
    public byte? IsUse { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    public long? CreateUserId { get; set; }
}
