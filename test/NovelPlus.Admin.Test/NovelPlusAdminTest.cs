using Microsoft.AspNetCore.Mvc.Testing;

namespace NovelPlus.Admin.Test
{
    public class NovelPlusAdminTest(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
    {
        [Fact]
        public void Test1()
        {
            var client = factory.CreateClient();
        }
    }
}
