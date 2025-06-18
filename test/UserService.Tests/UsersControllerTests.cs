using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using UserService.Host.Api;
using UserService.Service.Domain.Entities;
using Xunit;

namespace UserService.Tests
{
    public class UsersControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public UsersControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetAll_ReturnsTwoUsers()
        {
            var client = _factory.CreateClient();
            var users = await client.GetFromJsonAsync<User[]>("/api/Users");
            Assert.NotNull(users);
            Assert.Equal(2, users!.Length);
        }
    }
}
