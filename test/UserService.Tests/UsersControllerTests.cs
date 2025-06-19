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

        [Fact]
        public async Task GetById_ReturnsUser()
        {
            var client = _factory.CreateClient();
            var user = await client.GetFromJsonAsync<User>("/api/Users/1");
            Assert.NotNull(user);
            Assert.Equal("Alice", user!.UserName);
        }

        [Fact]
        public async Task GetById_NotFound()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("/api/Users/99");
            Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
