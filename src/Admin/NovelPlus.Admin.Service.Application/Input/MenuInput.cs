namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 菜单输入
/// </summary>
public class MenuInput
{
    /// <summary>
    /// 菜单名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 菜单地址
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// 权限标识
    /// </summary>
    public string Perms { get; set; } = string.Empty;
}
