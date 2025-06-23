namespace NovelPlus.Portal.Service.Application.Input;

/// <summary>
/// 用户注册登录输入
/// </summary>
public class UserInput
{
    /// <summary>
    /// 用户名
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// 登录密码
    /// </summary>
    public string Password { get; set; } = string.Empty;
}
