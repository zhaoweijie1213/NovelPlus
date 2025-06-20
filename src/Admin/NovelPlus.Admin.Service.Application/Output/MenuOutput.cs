namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 菜单输出
/// </summary>
public class MenuOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 菜单名称
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
