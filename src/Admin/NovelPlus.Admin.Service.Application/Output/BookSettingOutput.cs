namespace NovelPlus.Admin.Service.Application.Output;

/// <summary>
/// 首页小说设置输出
/// </summary>
public class BookSettingOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 小说ID
    /// </summary>
    public long? BookId { get; set; }

    /// <summary>
    /// 排序值
    /// </summary>
    public byte? Sort { get; set; }

    /// <summary>
    /// 类型
    /// </summary>
    public byte? Type { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 更新人ID
    /// </summary>
    public long? UpdateUserId { get; set; }
}
