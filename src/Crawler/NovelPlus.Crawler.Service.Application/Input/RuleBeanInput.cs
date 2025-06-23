using System.Collections.Generic;

namespace NovelPlus.Crawler.Service.Application.Input;

/// <summary>
/// 爬虫解析规则输入
/// </summary>
public class RuleBeanInput
{
    /// <summary>网页编码</summary>
    public string Charset { get; set; } = string.Empty;
    /// <summary>更新列表地址</summary>
    public string? UpdateBookListUrl { get; set; }
    /// <summary>书籍列表地址</summary>
    public string? BookListUrl { get; set; }
    /// <summary>分类规则</summary>
    public Dictionary<string, string>? CatIdRule { get; set; }
    /// <summary>状态规则</summary>
    public Dictionary<string, byte>? BookStatusRule { get; set; }
    /// <summary>书籍编号正则</summary>
    public string? BookIdPatten { get; set; }
    /// <summary>分页正则</summary>
    public string? PagePatten { get; set; }
    /// <summary>总页数正则</summary>
    public string? TotalPagePatten { get; set; }
    /// <summary>书籍详情地址</summary>
    public string? BookDetailUrl { get; set; }
    /// <summary>书名正则</summary>
    public string? BookNamePatten { get; set; }
    /// <summary>作者名正则</summary>
    public string? AuthorNamePatten { get; set; }
    /// <summary>封面地址正则</summary>
    public string? PicUrlPatten { get; set; }
    /// <summary>状态正则</summary>
    public string? StatusPatten { get; set; }
    /// <summary>评分正则</summary>
    public string? ScorePatten { get; set; }
    /// <summary>点击量正则</summary>
    public string? VisitCountPatten { get; set; }
    /// <summary>简介起始标记</summary>
    public string? DescStart { get; set; }
    /// <summary>简介结束标记</summary>
    public string? DescEnd { get; set; }
    /// <summary>更新时间正则</summary>
    public string? UpadateTimePatten { get; set; }
    /// <summary>更新时间格式</summary>
    public string? UpadateTimeFormatPatten { get; set; }
    /// <summary>目录列表地址</summary>
    public string? BookIndexUrl { get; set; }
    /// <summary>目录ID正则</summary>
    public string? IndexIdPatten { get; set; }
    /// <summary>目录名正则</summary>
    public string? IndexNamePatten { get; set; }
    /// <summary>章节内容地址</summary>
    public string? BookContentUrl { get; set; }
    /// <summary>正文开始标记</summary>
    public string? ContentStart { get; set; }
    /// <summary>正文结束标记</summary>
    public string? ContentEnd { get; set; }
    /// <summary>图片前缀</summary>
    public string? PicUrlPrefix { get; set; }
    /// <summary>目录起始标记</summary>
    public string? BookIndexStart { get; set; }
}
