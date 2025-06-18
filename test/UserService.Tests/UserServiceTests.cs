using UserService.Service.Application;
using Xunit;

namespace UserService.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void GetAll_ReturnsUsers()
        {
            IUserService service = new UserService.Service.Application.UserService();
            var users = service.GetAll().ToList();
            Assert.Equal(2, users.Count);
        }

        [Fact]
        public void GetById_ReturnsUser()
        {
            IUserService service = new UserService.Service.Application.UserService();
            var user = service.GetById(1);
            Assert.NotNull(user);
            Assert.Equal("Alice", user!.UserName);
        }

        [Fact]
        public void GetById_NotFound()
        {
            IUserService service = new UserService.Service.Application.UserService();
            var user = service.GetById(99);
            Assert.Null(user);
        }
    }
}
