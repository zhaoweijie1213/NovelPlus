using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NovelPlus.Crawler.Service.Application.Services;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Services;
using Quartz;
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
    public async Task ScheduleJob_ExecuteOnce()
    {
        var http = new FakeHttpClient();
        var parser = new CrawlParser(http);
        var config = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["ConnectionStrings:NovelPlus"] = ""
            })
            .Build();
        var service = new CrawlerTaskService(parser, config);
        var rule = new RuleBean
        {
            BookDetailUrl = "http://t/{bookId}",
            BookNamePatten = "//*[@id='name']",
            AuthorNamePatten = "//*[@id='author']",
            Charset = "UTF-8"
        };
        await service.CreateTaskAsync("job1", rule, "1");
        await service.StartAsync();
        await Task.WhenAny(http.Tcs.Task, Task.Delay(2000));
        await service.StopAsync();
        Assert.True(http.Tcs.Task.IsCompleted);
    }
}
