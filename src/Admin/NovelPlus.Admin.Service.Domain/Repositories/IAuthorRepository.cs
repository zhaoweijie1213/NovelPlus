using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 作者表仓储接口
/// </summary>
public interface IAuthorRepository
{
    /// <summary>
    /// 查询单个作者
    /// </summary>
    Task<AuthorEntity?> GetAsync(long id);

    /// <summary>
    /// 查询作者列表
    /// </summary>
    Task<List<AuthorEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询作者数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增作者
    /// </summary>
    Task<int> SaveAsync(AuthorEntity author);

    /// <summary>
    /// 更新作者
    /// </summary>
    Task<int> UpdateAsync(AuthorEntity author);

    /// <summary>
    /// 删除作者
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除作者
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    Task<Dictionary<object, object>> TableStaAsync(DateTime minDate);
}
