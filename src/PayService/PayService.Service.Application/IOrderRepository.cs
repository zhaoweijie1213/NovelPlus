namespace PayService.Service.Application;

using System;
using System.Collections.Generic;
using global::PayService.Service.Domain.Entities;

/// <summary>
/// 订单仓储接口
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// 根据ID获取订单
    /// </summary>
    Order? Get(long id);

    /// <summary>
    /// 条件查询订单
    /// </summary>
    IEnumerable<Order> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存订单
    /// </summary>
    int Save(Order order);

    /// <summary>
    /// 更新订单
    /// </summary>
    int Update(Order order);

    /// <summary>
    /// 删除订单
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除订单
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
