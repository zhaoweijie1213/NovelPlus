namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 用户输出
/// </summary>
public class UserOutput
{
    public long Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string NickName { get; set; } = string.Empty;
    public string UserPhoto { get; set; } = string.Empty;
    public byte? UserSex { get; set; }
    public long AccountBalance { get; set; }
    public byte Status { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
