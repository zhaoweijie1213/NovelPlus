using System.Net.Http.Json;
using CrawlService.Host.Api;
using CrawlService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace CrawlService.Tests;

public class TasksControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TasksControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsTask()
    {
        var client = _factory.CreateClient();
        var tasks = await client.GetFromJsonAsync<SpiderTask[]>("/api/Tasks");
        Assert.NotNull(tasks);
        Assert.Single(tasks!);
    }
}
