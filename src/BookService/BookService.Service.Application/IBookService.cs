using System.Collections.Generic;
using BookService.Service.Domain.Entities;

namespace BookService.Service.Application;

/// <summary>
/// 书籍业务接口
/// </summary>
public interface IBookService
{
    /// <summary>
    /// 获取全部书籍
    /// </summary>
    IEnumerable<Book> GetAll();

    /// <summary>
    /// 根据ID获取书籍
    /// </summary>
    /// <param name="id">书籍ID</param>
    /// <returns>书籍实体</returns>
    Book? GetById(int id);
}
