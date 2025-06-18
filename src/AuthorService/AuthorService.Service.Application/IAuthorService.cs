using System.Collections.Generic;
using AuthorService.Service.Domain.Entities;

namespace AuthorService.Service.Application;

/// <summary>
/// 作家业务接口
/// </summary>
public interface IAuthorService
{
    /// <summary>
    /// 获取全部作家
    /// </summary>
    IEnumerable<Author> GetAll();
}
