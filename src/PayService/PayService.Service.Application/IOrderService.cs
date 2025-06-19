using System;
using System.Collections.Generic;
using PayService.Service.Domain.Entities;

namespace PayService.Service.Application;

/// <summary>
/// 订单业务接口
/// </summary>
public interface IOrderService
{
    /// <summary>
    /// 获取全部订单
    /// </summary>
    IEnumerable<Order> GetAll();

    /// <summary>
    /// 根据ID获取订单
    /// </summary>
    Order? GetById(long id);

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
