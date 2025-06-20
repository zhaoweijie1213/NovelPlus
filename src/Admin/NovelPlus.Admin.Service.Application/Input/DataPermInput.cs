namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 数据权限输入
/// </summary>
public class DataPermInput
{
    /// <summary>
    /// 权限名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 数据表名称
    /// </summary>
    public string TableName { get; set; } = string.Empty;

    /// <summary>
    /// 所属模块
    /// </summary>
    public string ModuleName { get; set; } = string.Empty;
}
