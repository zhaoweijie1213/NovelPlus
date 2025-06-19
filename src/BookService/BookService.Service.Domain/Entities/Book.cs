using System;

namespace BookService.Service.Domain.Entities;

/// <summary>
/// 书籍实体
/// </summary>
public class Book
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 作品方向，0：男频，1：女频
    /// </summary>
    public int WorkDirection { get; set; }

    /// <summary>
    /// 分类ID
    /// </summary>
    public int CatId { get; set; }

    /// <summary>
    /// 分类名
    /// </summary>
    public string CatName { get; set; } = string.Empty;

    /// <summary>
    /// 小说封面
    /// </summary>
    public string PicUrl { get; set; } = string.Empty;

    /// <summary>
    /// 小说名
    /// </summary>
    public string BookName { get; set; } = string.Empty;

    /// <summary>
    /// 作者ID
    /// </summary>
    public long AuthorId { get; set; }

    /// <summary>
    /// 作者名
    /// </summary>
    public string AuthorName { get; set; } = string.Empty;

    /// <summary>
    /// 书籍描述
    /// </summary>
    public string BookDesc { get; set; } = string.Empty;

    /// <summary>
    /// 评分，预留字段
    /// </summary>
    public float? Score { get; set; }

    /// <summary>
    /// 书籍状态，0：连载中，1：已完结
    /// </summary>
    public int BookStatus { get; set; }

    /// <summary>
    /// 点击量
    /// </summary>
    public long VisitCount { get; set; }

    /// <summary>
    /// 总字数
    /// </summary>
    public int WordCount { get; set; }

    /// <summary>
    /// 评论数
    /// </summary>
    public int CommentCount { get; set; }

    /// <summary>
    /// 昨日订阅数
    /// </summary>
    public int YesterdayBuy { get; set; }

    /// <summary>
    /// 最新目录ID
    /// </summary>
    public long LastIndexId { get; set; }

    /// <summary>
    /// 最新目录名
    /// </summary>
    public string LastIndexName { get; set; } = string.Empty;

    /// <summary>
    /// 最新目录更新时间
    /// </summary>
    public DateTime? LastIndexUpdateTime { get; set; }

    /// <summary>
    /// 是否收费，1：收费，0：免费
    /// </summary>
    public int IsVip { get; set; }

    /// <summary>
    /// 状态，0：入库，1：上架
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 爬虫源站ID
    /// </summary>
    public int? CrawlSourceId { get; set; }

    /// <summary>
    /// 抓取的源站小说ID
    /// </summary>
    public string? CrawlBookId { get; set; }

    /// <summary>
    /// 最后一次的抓取时间
    /// </summary>
    public DateTime? CrawlLastTime { get; set; }

    /// <summary>
    /// 是否已停止更新，0：未停止，1：已停止
    /// </summary>
    public int? CrawlIsStop { get; set; }
}
