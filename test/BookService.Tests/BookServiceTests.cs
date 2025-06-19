using BookService.Service.Application;
using Xunit;

namespace BookService.Tests;

public class BookServiceTests
{
    [Fact]
    public void GetAll_ReturnsBooks()
    {
        IBookService service = new BookService.Service.Application.BookService();
        var books = service.GetAll().ToList();
        Assert.Single(books);
        Assert.Equal("示例书籍", books[0].BookName);
    }
}
