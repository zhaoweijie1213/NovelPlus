using System;
using SqlSugar;

namespace NovelPlus.Portal.Service.Domain.Entities;

/// <summary>
/// 小说表
/// </summary>
[SugarTable("book")]
public class BookEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 作品方向，0：男频，1：女频
    /// </summary>
    [SugarColumn(ColumnName = "work_direction")]
    public byte? WorkDirection { get; set; }

    /// <summary>
    /// 分类ID
    /// </summary>
    [SugarColumn(ColumnName = "cat_id")]
    public int? CatId { get; set; }

    /// <summary>
    /// 分类名
    /// </summary>
    [SugarColumn(ColumnName = "cat_name")]
    public string CatName { get; set; } = string.Empty;

    /// <summary>
    /// 小说封面
    /// </summary>
    [SugarColumn(ColumnName = "pic_url")]
    public string PicUrl { get; set; } = string.Empty;

    /// <summary>
    /// 小说名
    /// </summary>
    [SugarColumn(ColumnName = "book_name")]
    public string BookName { get; set; } = string.Empty;

    /// <summary>
    /// 作者id
    /// </summary>
    [SugarColumn(ColumnName = "author_id")]
    public long? AuthorId { get; set; }

    /// <summary>
    /// 作者名
    /// </summary>
    [SugarColumn(ColumnName = "author_name")]
    public string AuthorName { get; set; } = string.Empty;

    /// <summary>
    /// 书籍描述
    /// </summary>
    [SugarColumn(ColumnName = "book_desc")]
    public string BookDesc { get; set; } = string.Empty;

    /// <summary>
    /// 评分，预留字段
    /// </summary>
    [SugarColumn(ColumnName = "score")]
    public decimal Score { get; set; }

    /// <summary>
    /// 书籍状态，0：连载中，1：已完结
    /// </summary>
    [SugarColumn(ColumnName = "book_status")]
    public byte BookStatus { get; set; }

    /// <summary>
    /// 点击量
    /// </summary>
    [SugarColumn(ColumnName = "visit_count")]
    public long? VisitCount { get; set; }

    /// <summary>
    /// 总字数
    /// </summary>
    [SugarColumn(ColumnName = "word_count")]
    public int? WordCount { get; set; }

    /// <summary>
    /// 评论数
    /// </summary>
    [SugarColumn(ColumnName = "comment_count")]
    public int? CommentCount { get; set; }

    /// <summary>
    /// 昨日订阅数
    /// </summary>
    [SugarColumn(ColumnName = "yesterday_buy")]
    public int? YesterdayBuy { get; set; }

    /// <summary>
    /// 最新目录ID
    /// </summary>
    [SugarColumn(ColumnName = "last_index_id")]
    public long? LastIndexId { get; set; }

    /// <summary>
    /// 最新目录名
    /// </summary>
    [SugarColumn(ColumnName = "last_index_name")]
    public string LastIndexName { get; set; } = string.Empty;

    /// <summary>
    /// 最新目录更新时间
    /// </summary>
    [SugarColumn(ColumnName = "last_index_update_time")]
    public DateTime? LastIndexUpdateTime { get; set; }

    /// <summary>
    /// 是否收费，1：收费，0：免费
    /// </summary>
    [SugarColumn(ColumnName = "is_vip")]
    public byte? IsVip { get; set; }

    /// <summary>
    /// 状态，0：入库，1：上架
    /// </summary>
    [SugarColumn(ColumnName = "status")]
    public byte? Status { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [SugarColumn(ColumnName = "update_time")]
    public DateTime UpdateTime { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 爬虫源站ID
    /// </summary>
    [SugarColumn(ColumnName = "crawl_source_id")]
    public int? CrawlSourceId { get; set; }

    /// <summary>
    /// 抓取的源站小说ID
    /// </summary>
    [SugarColumn(ColumnName = "crawl_book_id")]
    public string CrawlBookId { get; set; } = string.Empty;

    /// <summary>
    /// 最后一次的抓取时间
    /// </summary>
    [SugarColumn(ColumnName = "crawl_last_time")]
    public DateTime? CrawlLastTime { get; set; }

    /// <summary>
    /// 是否已停止更新，0：未停止，1：已停止
    /// </summary>
    [SugarColumn(ColumnName = "crawl_is_stop")]
    public byte? CrawlIsStop { get; set; }
}
