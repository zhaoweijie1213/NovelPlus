namespace AdminService.Service.Domain.Entities;

/// <summary>
/// 管理员实体
/// </summary>
public class AdminUser
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName { get; set; } = string.Empty;
}
