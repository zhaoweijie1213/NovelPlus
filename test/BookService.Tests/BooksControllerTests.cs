using System.Net.Http.Json;
using BookService.Host.Api;
using BookService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BookService.Tests;

public class BooksControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public BooksControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsBook()
    {
        var client = _factory.CreateClient();
        var books = await client.GetFromJsonAsync<Book[]>("/api/Books");
        Assert.NotNull(books);
        Assert.Single(books!);
    }
}
