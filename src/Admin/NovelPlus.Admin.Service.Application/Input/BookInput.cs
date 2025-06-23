using System;

namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 小说输入
/// </summary>
public class BookInput
{
    /// <summary>
    /// 主键，用于更新
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 作品方向
    /// </summary>
    public byte? WorkDirection { get; set; }

    /// <summary>
    /// 分类ID
    /// </summary>
    public int? CatId { get; set; }

    /// <summary>
    /// 分类名称
    /// </summary>
    public string CatName { get; set; } = string.Empty;

    /// <summary>
    /// 封面地址
    /// </summary>
    public string PicUrl { get; set; } = string.Empty;

    /// <summary>
    /// 小说名称
    /// </summary>
    public string BookName { get; set; } = string.Empty;

    /// <summary>
    /// 作者ID
    /// </summary>
    public long? AuthorId { get; set; }

    /// <summary>
    /// 作者名称
    /// </summary>
    public string AuthorName { get; set; } = string.Empty;

    /// <summary>
    /// 小说描述
    /// </summary>
    public string BookDesc { get; set; } = string.Empty;

    /// <summary>
    /// 评分
    /// </summary>
    public decimal Score { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public byte BookStatus { get; set; }

    /// <summary>
    /// 点击量
    /// </summary>
    public long? VisitCount { get; set; }

    /// <summary>
    /// 字数
    /// </summary>
    public int? WordCount { get; set; }

    /// <summary>
    /// 评论数量
    /// </summary>
    public int? CommentCount { get; set; }

    /// <summary>
    /// 昨日订阅数
    /// </summary>
    public int? YesterdayBuy { get; set; }

    /// <summary>
    /// 最新章节ID
    /// </summary>
    public long? LastIndexId { get; set; }

    /// <summary>
    /// 最新章节名称
    /// </summary>
    public string LastIndexName { get; set; } = string.Empty;

    /// <summary>
    /// 最新章节更新时间
    /// </summary>
    public DateTime? LastIndexUpdateTime { get; set; }

    /// <summary>
    /// 是否 VIP
    /// </summary>
    public byte? IsVip { get; set; }

    /// <summary>
    /// 上架状态
    /// </summary>
    public byte? Status { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime UpdateTime { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 爬虫来源ID
    /// </summary>
    public int? CrawlSourceId { get; set; }

    /// <summary>
    /// 爬虫小说ID
    /// </summary>
    public string CrawlBookId { get; set; } = string.Empty;

    /// <summary>
    /// 爬虫上次时间
    /// </summary>
    public DateTime? CrawlLastTime { get; set; }

    /// <summary>
    /// 是否停止爬虫
    /// </summary>
    public byte? CrawlIsStop { get; set; }
}
