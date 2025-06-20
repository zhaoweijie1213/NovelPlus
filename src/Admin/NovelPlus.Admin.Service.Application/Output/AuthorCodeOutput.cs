namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 作家邀请码输出
/// </summary>
public class AuthorCodeOutput
{
    public long Id { get; set; }
    public string InviteCode { get; set; } = string.Empty;
    public DateTime? ValidityTime { get; set; }
    public byte? IsUse { get; set; }
    public DateTime? CreateTime { get; set; }
    public long? CreateUserId { get; set; }
}
