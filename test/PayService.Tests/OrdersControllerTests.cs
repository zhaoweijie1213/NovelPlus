using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PayService.Host.Api;
using PayService.Service.Domain.Entities;
using Xunit;

namespace PayService.Tests;

public class OrdersControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public OrdersControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsOrder()
    {
        var client = _factory.CreateClient();
        var orders = await client.GetFromJsonAsync<Order[]>("/api/Orders");
        Assert.NotNull(orders);
        Assert.Single(orders!);
    }
}
