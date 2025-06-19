using System;
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

    /// <summary>
    /// 根据ID获取作家
    /// </summary>
    Author? GetById(long id);

    /// <summary>
    /// 条件查询作家
    /// </summary>
    IEnumerable<Author> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存作家
    /// </summary>
    int Save(Author author);

    /// <summary>
    /// 更新作家
    /// </summary>
    int Update(Author author);

    /// <summary>
    /// 删除作家
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除作家
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
