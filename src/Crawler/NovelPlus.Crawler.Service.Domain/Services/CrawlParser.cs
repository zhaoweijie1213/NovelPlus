using HtmlAgilityPack;
using System.Text.RegularExpressions;
using NovelPlus.Crawler.Service.Domain.Entities;

namespace NovelPlus.Crawler.Service.Domain.Services;

/// <summary>
/// 爬虫解析器
/// </summary>
public class CrawlParser(ICrawlHttpClient httpClient)
{
    private readonly ICrawlHttpClient _httpClient = httpClient;

    /// <summary>
    /// 解析小说信息
    /// </summary>
    /// <param name="rule">解析规则</param>
    /// <param name="bookId">源站小说ID</param>
    /// <returns>小说实体</returns>
    public async Task<BookEntity?> ParseBookAsync(RuleBean rule, string bookId)
    {
        var url = rule.BookDetailUrl.Replace("{bookId}", bookId);
        var html = await _httpClient.GetAsync(url, rule.Charset);
        if (html is null)
        {
            return null;
        }

        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        var book = new BookEntity();

        // 支持 XPath 或正则提取
        var nameNode = doc.DocumentNode.SelectSingleNode(rule.BookNamePatten);
        if (nameNode != null)
        {
            book.BookName = nameNode.InnerText.Trim();
        }
        else
        {
            var m = Regex.Match(html, rule.BookNamePatten);
            if (m.Success)
            {
                book.BookName = m.Groups[1].Value.Trim();
            }
        }

        var authorNode = doc.DocumentNode.SelectSingleNode(rule.AuthorNamePatten);
        if (authorNode != null)
        {
            book.AuthorName = authorNode.InnerText.Trim();
        }
        else
        {
            var m = Regex.Match(html, rule.AuthorNamePatten);
            if (m.Success)
            {
                book.AuthorName = m.Groups[1].Value.Trim();
            }
        }

        return book;
    }
}
