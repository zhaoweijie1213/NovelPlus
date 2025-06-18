using System.Net.Http.Json;
using FileService.Host.Api;
using FileService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FileService.Tests;

public class FilesControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public FilesControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsFile()
    {
        var client = _factory.CreateClient();
        var files = await client.GetFromJsonAsync<FileRecord[]>("/api/Files");
        Assert.NotNull(files);
        Assert.Single(files!);
    }
}
