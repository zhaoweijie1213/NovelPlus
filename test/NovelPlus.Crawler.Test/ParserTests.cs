using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Services;
using Xunit;

namespace NovelPlus.Crawler.Test;

/// <summary>
/// 爬虫解析器测试
/// </summary>
public class ParserTests
{
    private class FakeHttpClient : ICrawlHttpClient
    {
        public Task<string?> GetAsync(string url, string charset)
        {
            var html = "<html><h1 id='name'>MyBook</h1><span id='author'>AuthorA</span></html>";
            return Task.FromResult<string?>(html);
        }
    }

    [Fact]
    public async Task ParseBook_ReturnsBookNameAndAuthor()
    {
        var client = new FakeHttpClient();
        var parser = new CrawlParser(client);
        var rule = new RuleBean
        {
            BookDetailUrl = "http://test/{bookId}",
            BookNamePatten = "//*[@id='name']",
            AuthorNamePatten = "//*[@id='author']",
            Charset = "UTF-8"
        };

        var book = await parser.ParseBookAsync(rule, "1");

        Assert.NotNull(book);
        Assert.Equal("MyBook", book!.BookName);
        Assert.Equal("AuthorA", book.AuthorName);
    }
}
