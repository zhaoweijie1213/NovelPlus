using ContentService.Service.Application;
using Xunit;

namespace ContentService.Tests;

public class ContentServiceTests
{
    [Fact]
    public void GetAll_ReturnsNews()
    {
        IContentService service = new ContentService.Service.Application.ContentService();
        var news = service.GetAll().ToList();
        Assert.Single(news);
        Assert.Equal("欢迎", news[0].Title);
    }
}
