namespace AuthService.Service.Domain.Entities;

/// <summary>
/// 用户实体
/// </summary>
public class User
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// 密码哈希
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;
}
