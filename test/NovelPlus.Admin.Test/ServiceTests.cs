using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging.Abstractions;
using NovelPlus.Admin.Service.Application.Services;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Test.Fakes;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NovelPlus.Admin.Test;

public class ServiceTests : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task BookService_Crud_Works()
    {
        var repo = new InMemoryBookRepository();
        var service = new BookService(repo, NullLogger<BookService>.Instance);
        var book = new BookEntity { BookName = "test" };
        await service.SaveAsync(book);
        var list = await service.ListAsync(new Dictionary<string, object>());
        Assert.Single(list);
        var count = await service.CountAsync(new Dictionary<string, object>());
        Assert.Equal(1, count);
        book.BookDesc = "desc";
        await service.UpdateAsync(book);
        var fetched = await service.GetAsync(book.Id);
        Assert.Equal("desc", fetched?.BookDesc);
        await service.RemoveAsync(book.Id);
        count = await service.CountAsync(new Dictionary<string, object>());
        Assert.Equal(0, count);
    }

    [Fact]
    public async Task AuthorService_Crud_Works()
    {
        var repo = new InMemoryAuthorRepository();
        var service = new AuthorService(repo, NullLogger<AuthorService>.Instance);
        var author = new AuthorEntity { PenName = "pen" };
        await service.SaveAsync(author);
        var list = await service.ListAsync(new Dictionary<string, object>());
        Assert.Single(list);
        author.PenName = "new";
        await service.UpdateAsync(author);
        var entity = await service.GetAsync(author.Id);
        Assert.Equal("new", entity?.PenName);
        await service.RemoveAsync(author.Id);
        Assert.Equal(0, await service.CountAsync(new Dictionary<string, object>()));
    }

    [Fact]
    public async Task CategoryService_Crud_Works()
    {
        var repo = new InMemoryCategoryRepository();
        var service = new CategoryService(repo, NullLogger<CategoryService>.Instance);
        var category = new CategoryEntity { Name = "c" };
        await service.SaveAsync(category);
        var list = await service.ListAsync(new Dictionary<string, object>());
        Assert.Single(list);
        category.Name = "c2";
        await service.UpdateAsync(category);
        var entity = await service.GetAsync(category.Id);
        Assert.Equal("c2", entity?.Name);
        await service.RemoveAsync(category.Id);
        Assert.Equal(0, await service.CountAsync(new Dictionary<string, object>()));
    }
}
