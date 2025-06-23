namespace NovelPlus.Crawler.Service.Domain.Entities;

/// <summary>
/// 爬虫解析规则
/// </summary>
public class RuleBean
{
    /// <summary>网页编码</summary>
    public string Charset { get; set; } = string.Empty;
    /// <summary>书籍详情地址</summary>
    public string BookDetailUrl { get; set; } = string.Empty;
    /// <summary>书名节点 XPath 或正则</summary>
    public string BookNamePatten { get; set; } = string.Empty;
    /// <summary>作者名节点 XPath 或正则</summary>
    public string AuthorNamePatten { get; set; } = string.Empty;
    /// <summary>目录列表地址</summary>
    public string BookIndexUrl { get; set; } = string.Empty;
    /// <summary>目录ID正则</summary>
    public string IndexIdPatten { get; set; } = string.Empty;
    /// <summary>目录名正则</summary>
    public string IndexNamePatten { get; set; } = string.Empty;
    /// <summary>章节内容地址</summary>
    public string BookContentUrl { get; set; } = string.Empty;
    /// <summary>正文开始标记</summary>
    public string ContentStart { get; set; } = string.Empty;
    /// <summary>正文结束标记</summary>
    public string ContentEnd { get; set; } = string.Empty;
}
