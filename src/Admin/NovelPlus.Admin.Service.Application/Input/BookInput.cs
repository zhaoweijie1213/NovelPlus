using System;

namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 小说输入
/// </summary>
public class BookInput
{
    public byte? WorkDirection { get; set; }
    public int? CatId { get; set; }
    public string CatName { get; set; } = string.Empty;
    public string PicUrl { get; set; } = string.Empty;
    public string BookName { get; set; } = string.Empty;
    public long? AuthorId { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public string BookDesc { get; set; } = string.Empty;
    public decimal Score { get; set; }
    public byte BookStatus { get; set; }
    public long? VisitCount { get; set; }
    public int? WordCount { get; set; }
    public int? CommentCount { get; set; }
    public int? YesterdayBuy { get; set; }
    public long? LastIndexId { get; set; }
    public string LastIndexName { get; set; } = string.Empty;
    public DateTime? LastIndexUpdateTime { get; set; }
    public byte? IsVip { get; set; }
    public byte? Status { get; set; }
    public DateTime UpdateTime { get; set; }
    public DateTime? CreateTime { get; set; }
    public int? CrawlSourceId { get; set; }
    public string CrawlBookId { get; set; } = string.Empty;
    public DateTime? CrawlLastTime { get; set; }
    public byte? CrawlIsStop { get; set; }
}
