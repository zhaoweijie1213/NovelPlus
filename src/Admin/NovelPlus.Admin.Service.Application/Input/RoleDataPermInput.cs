namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 角色数据权限输入
/// </summary>
public class RoleDataPermInput
{
    /// <summary>
    /// 角色ID
    /// </summary>
    public long? RoleId { get; set; }

    /// <summary>
    /// 权限ID
    /// </summary>
    public long? PermId { get; set; }
}
