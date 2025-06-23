using System.Threading.Tasks;
using NovelPlus.Crawler.Service.Application.Services;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Services;
using Xunit;

namespace NovelPlus.Crawler.Test;

/// <summary>
/// 调度服务测试
/// </summary>
public class SchedulerTests
{
    private class FakeHttpClient : ICrawlHttpClient
    {
        public readonly TaskCompletionSource<bool> Tcs = new(TaskCreationOptions.RunContinuationsAsynchronously);
        public Task<string?> GetAsync(string url, string charset)
        {
            Tcs.TrySetResult(true);
            var html = "<html><h1 id='name'>MyBook</h1><span id='author'>AuthorA</span></html>";
            return Task.FromResult<string?>(html);
        }
    }

    [Fact]
    public async Task StartTask_RunOnce()
    {
        var http = new FakeHttpClient();
        var parser = new CrawlParser(http);
        var service = new CrawlerTaskService(parser);
        var rule = new RuleBean
        {
            BookDetailUrl = "http://t/{bookId}",
            BookNamePatten = "//*[@id='name']",
            AuthorNamePatten = "//*[@id='author']",
            Charset = "UTF-8"
        };
        await service.StartTaskAsync("job1", rule, "1");
        await Task.WhenAny(http.Tcs.Task, Task.Delay(2000));
        service.StopTask("job1");
        Assert.True(http.Tcs.Task.IsCompleted);
    }
}
