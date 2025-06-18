using CrawlService.Service.Application;
using Xunit;

namespace CrawlService.Tests;

public class SpiderServiceTests
{
    [Fact]
    public void GetAll_ReturnsTasks()
    {
        ISpiderService service = new CrawlService.Service.Application.SpiderService();
        var tasks = service.GetAll().ToList();
        Assert.Single(tasks);
        Assert.Equal("https://example.com", tasks[0].Url);
    }
}
