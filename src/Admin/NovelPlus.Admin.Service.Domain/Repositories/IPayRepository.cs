using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 充值订单仓储接口
/// </summary>
public interface IPayRepository : ITransientDependency
{
    /// <summary>
    /// 查询订单
    /// </summary>
    Task<OrderPayEntity?> GetAsync(long id);

    /// <summary>
    /// 订单列表
    /// </summary>
    Task<List<OrderPayEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 订单数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增订单
    /// </summary>
    Task<int> SaveAsync(OrderPayEntity order);

    /// <summary>
    /// 更新订单
    /// </summary>
    Task<int> UpdateAsync(OrderPayEntity order);

    /// <summary>
    /// 删除订单
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除订单
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 表数据统计
    /// </summary>
    Task<Dictionary<object, object>> TableStaAsync(DateTime minDate);
}
