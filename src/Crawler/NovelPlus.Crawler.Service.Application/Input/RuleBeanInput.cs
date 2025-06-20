using System.Collections.Generic;

namespace NovelPlus.Crawler.Service.Application.Input;

/// <summary>
/// 爬虫解析规则输入
/// </summary>
public class RuleBeanInput
{
    public string Charset { get; set; } = string.Empty;
    public string? UpdateBookListUrl { get; set; }
    public string? BookListUrl { get; set; }
    public Dictionary<string, string>? CatIdRule { get; set; }
    public Dictionary<string, byte>? BookStatusRule { get; set; }
    public string? BookIdPatten { get; set; }
    public string? PagePatten { get; set; }
    public string? TotalPagePatten { get; set; }
    public string? BookDetailUrl { get; set; }
    public string? BookNamePatten { get; set; }
    public string? AuthorNamePatten { get; set; }
    public string? PicUrlPatten { get; set; }
    public string? StatusPatten { get; set; }
    public string? ScorePatten { get; set; }
    public string? VisitCountPatten { get; set; }
    public string? DescStart { get; set; }
    public string? DescEnd { get; set; }
    public string? UpadateTimePatten { get; set; }
    public string? UpadateTimeFormatPatten { get; set; }
    public string? BookIndexUrl { get; set; }
    public string? IndexIdPatten { get; set; }
    public string? IndexNamePatten { get; set; }
    public string? BookContentUrl { get; set; }
    public string? ContentStart { get; set; }
    public string? ContentEnd { get; set; }
    public string? PicUrlPrefix { get; set; }
    public string? BookIndexStart { get; set; }
}
