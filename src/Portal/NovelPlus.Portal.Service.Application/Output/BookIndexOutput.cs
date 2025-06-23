namespace NovelPlus.Portal.Service.Application.Output;

/// <summary>
/// 小说目录输出
/// </summary>
public class BookIndexOutput
{
    /// <summary>
    /// 目录编号
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 小说编号
    /// </summary>
    public long BookId { get; set; }

    /// <summary>
    /// 章节序号
    /// </summary>
    public int IndexNum { get; set; }

    /// <summary>
    /// 章节名称
    /// </summary>
    public string IndexName { get; set; } = string.Empty;

    /// <summary>
    /// 字数
    /// </summary>
    public int? WordCount { get; set; }

    /// <summary>
    /// 是否 VIP
    /// </summary>
    public byte? IsVip { get; set; }

    /// <summary>
    /// 单章价格
    /// </summary>
    public int? BookPrice { get; set; }

    /// <summary>
    /// 存储类型
    /// </summary>
    public string StorageType { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
