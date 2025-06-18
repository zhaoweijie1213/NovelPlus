using System.Net.Http.Json;
using AdminService.Host.Api;
using AdminService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace AdminService.Tests;

public class AdminUsersControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public AdminUsersControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task GetAll_ReturnsAdmin()
    {
        var client = _factory.CreateClient();
        var admins = await client.GetFromJsonAsync<AdminUser[]>("/api/AdminUsers");
        Assert.NotNull(admins);
        Assert.Single(admins!);
    }
}
