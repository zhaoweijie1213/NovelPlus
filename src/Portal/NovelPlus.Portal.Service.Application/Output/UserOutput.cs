namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 用户输出
/// </summary>
public class UserOutput
{
    /// <summary>
    /// 用户编号
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// 登录密码
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 昵称
    /// </summary>
    public string NickName { get; set; } = string.Empty;

    /// <summary>
    /// 头像地址
    /// </summary>
    public string UserPhoto { get; set; } = string.Empty;

    /// <summary>
    /// 性别
    /// </summary>
    public byte? UserSex { get; set; }

    /// <summary>
    /// 账户余额
    /// </summary>
    public long AccountBalance { get; set; }

    /// <summary>
    /// 用户状态
    /// </summary>
    public byte Status { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
