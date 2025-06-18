using System.Net.Http.Json;
using ContentService.Host.Api;
using ContentService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace ContentService.Tests;

public class NewsControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public NewsControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsNews()
    {
        var client = _factory.CreateClient();
        var news = await client.GetFromJsonAsync<News[]>("/api/News");
        Assert.NotNull(news);
        Assert.Single(news!);
    }
}
