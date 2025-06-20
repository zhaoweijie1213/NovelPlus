namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 角色输出
/// </summary>
public class RoleOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 角色名称
    /// </summary>
    public string RoleName { get; set; } = string.Empty;
}
