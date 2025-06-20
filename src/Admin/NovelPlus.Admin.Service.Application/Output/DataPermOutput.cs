namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 数据权限输出
/// </summary>
public class DataPermOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 权限名称
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
