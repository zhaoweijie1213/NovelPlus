namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 部门输入
/// </summary>
public class DeptInput
{
    /// <summary>
    /// 部门名称
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 上级部门ID
    /// </summary>
    public long? ParentId { get; set; }
}
