namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 统计表数据输出
/// </summary>
public class StatTableOutput
{
    /// <summary>
    /// 日期列表
    /// </summary>
    public List<string> DateList { get; set; } = [];

    /// <summary>
    /// 用户统计
    /// </summary>
    public Dictionary<string, int> UserTableSta { get; set; } = new();

    /// <summary>
    /// 小说统计
    /// </summary>
    public Dictionary<string, int> BookTableSta { get; set; } = new();

    /// <summary>
    /// 作者统计
    /// </summary>
    public Dictionary<string, int> AuthorTableSta { get; set; } = new();

    /// <summary>
    /// 订单统计
    /// </summary>
    public Dictionary<string, int> OrderTableSta { get; set; } = new();
}
