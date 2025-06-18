using System.Collections.Generic;
using System.Linq;
using BookService.Service.Domain.Entities;

namespace BookService.Service.Application;

/// <summary>
/// 书籍业务实现
/// </summary>
public class BookService : IBookService
{
    /// <summary>
    /// 示例书籍列表
    /// </summary>
    private readonly List<Book> _books = new()
    {
        new Book { Id = 1, Title = "示例书籍" }
    };

    /// <inheritdoc />
    public IEnumerable<Book> GetAll() => _books;

    /// <inheritdoc />
    public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);
}
