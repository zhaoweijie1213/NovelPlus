using System.Collections.Generic;
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
}
