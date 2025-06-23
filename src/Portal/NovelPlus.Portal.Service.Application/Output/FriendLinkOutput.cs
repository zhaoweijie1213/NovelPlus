namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 友情链接输出
/// </summary>
public class FriendLinkOutput
{
    /// <summary>
    /// 主键
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 链接名称
    /// </summary>
    public string LinkName { get; set; } = string.Empty;

    /// <summary>
    /// 链接地址
    /// </summary>
    public string LinkUrl { get; set; } = string.Empty;

    /// <summary>
    /// 排序值
    /// </summary>
    public byte Sort { get; set; }

    /// <summary>
    /// 是否启用
    /// </summary>
    public byte IsOpen { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public long? UpdateUserId { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
