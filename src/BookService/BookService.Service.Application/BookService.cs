using System;
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
        new Book { Id = 1, BookName = "示例书籍" }
    };

    /// <inheritdoc />
    public IEnumerable<Book> GetAll() => _books;

    /// <inheritdoc />
    public Book? GetById(long id) => _books.FirstOrDefault(b => b.Id == id);

    /// <inheritdoc />
    public IEnumerable<Book> List(IDictionary<string, object> filters) => _books;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _books.Count;

    /// <inheritdoc />
    public int Save(Book book)
    {
        book.Id = _books.Max(b => b.Id) + 1;
        _books.Add(book);
        return 1;
    }

    /// <inheritdoc />
    public int Update(Book book)
    {
        var index = _books.FindIndex(b => b.Id == book.Id);
        if (index == -1) return 0;
        _books[index] = book;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book == null) return 0;
        _books.Remove(book);
        return 1;
    }

    /// <inheritdoc />
    public int BatchRemove(long[] ids)
    {
        var removed = 0;
        foreach (var id in ids) removed += Remove(id);
        return removed;
    }

    /// <inheritdoc />
    public IDictionary<object, object> TableStat(DateTime minDate)
    {
        return new Dictionary<object, object>();
    }
}
