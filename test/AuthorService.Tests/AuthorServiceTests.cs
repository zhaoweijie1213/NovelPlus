using AuthorService.Service.Application;
using Xunit;

namespace AuthorService.Tests;

public class AuthorServiceTests
{
    [Fact]
    public void GetAll_ReturnsAuthor()
    {
        IAuthorService service = new AuthorService.Service.Application.AuthorService();
        var authors = service.GetAll().ToList();
        Assert.Single(authors);
        Assert.Equal("匿名", authors[0].PenName);
    }
}
