namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 统计数量输出
/// </summary>
public class StatCountOutput
{
    /// <summary>
    /// 用户数量
    /// </summary>
    public int UserCount { get; set; }

    /// <summary>
    /// 作者数量
    /// </summary>
    public int AuthorCount { get; set; }

    /// <summary>
    /// 小说数量
    /// </summary>
    public int BookCount { get; set; }

    /// <summary>
    /// 充值订单数量
    /// </summary>
    public int OrderCount { get; set; }
}
