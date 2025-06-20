namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 系统用户输入
/// </summary>
public class UserInput
{
    /// <summary>
    /// 用户名
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 昵称
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
