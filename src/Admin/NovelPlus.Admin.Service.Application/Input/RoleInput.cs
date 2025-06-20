namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 角色输入
/// </summary>
public class RoleInput
{
    /// <summary>
    /// 角色名称
    /// </summary>
    public string RoleName { get; set; } = string.Empty;

    /// <summary>
    /// 角色标识
    /// </summary>
    public string RoleSign { get; set; } = string.Empty;
}
