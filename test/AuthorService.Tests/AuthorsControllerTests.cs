using System.Net.Http.Json;
using AuthorService.Host.Api;
using AuthorService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace AuthorService.Tests;

public class AuthorsControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public AuthorsControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsAuthor()
    {
        var client = _factory.CreateClient();
        var authors = await client.GetFromJsonAsync<Author[]>("/api/Authors");
        Assert.NotNull(authors);
        Assert.Single(authors!);
    }
}
