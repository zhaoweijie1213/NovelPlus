namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 部门输出
/// </summary>
public class DeptOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 部门名称
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
