using System;
using System.Collections.Generic;
using System.Linq;
using AuthorService.Service.Domain.Entities;

namespace AuthorService.Service.Application;

/// <summary>
/// 作家业务实现
/// </summary>
public class AuthorService : IAuthorService
{
    /// <summary>
    /// 内置作家列表，示例数据
    /// </summary>
    private readonly List<Author> _authors = new()
    {
        new Author { Id = 1, PenName = "匿名" }
    };

    /// <inheritdoc />
    public IEnumerable<Author> GetAll() => _authors;

    /// <inheritdoc />
    public Author? GetById(long id) => _authors.FirstOrDefault(a => a.Id == id);

    /// <inheritdoc />
    public IEnumerable<Author> List(IDictionary<string, object> filters) => _authors;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _authors.Count;

    /// <inheritdoc />
    public int Save(Author author)
    {
        author.Id = _authors.Max(a => a.Id) + 1;
        _authors.Add(author);
        return 1;
    }

    /// <inheritdoc />
    public int Update(Author author)
    {
        var index = _authors.FindIndex(a => a.Id == author.Id);
        if (index == -1) return 0;
        _authors[index] = author;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var author = _authors.FirstOrDefault(a => a.Id == id);
        if (author == null) return 0;
        _authors.Remove(author);
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
