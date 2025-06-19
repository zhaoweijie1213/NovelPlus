using System;
using System.Collections.Generic;
using System.Linq;
using PayService.Service.Domain.Entities;

namespace PayService.Service.Application;

/// <summary>
/// 订单业务实现
/// </summary>
public class OrderService : IOrderService
{
    /// <summary>
    /// 示例订单列表
    /// </summary>
    private readonly List<Order> _orders = new()
    {
        new Order { Id = 1, OutTradeNo = 100, TradeNo = "T123", TotalAmount = 99, UserId = 1, PayChannel = 1, PayStatus = 1, CreateTime = DateTime.Now }
    };

    /// <inheritdoc />
    public IEnumerable<Order> GetAll() => _orders;

    /// <inheritdoc />
    public Order? GetById(long id) => _orders.FirstOrDefault(o => o.Id == id);

    /// <inheritdoc />
    public IEnumerable<Order> List(IDictionary<string, object> filters) => _orders;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _orders.Count;

    /// <inheritdoc />
    public int Save(Order order)
    {
        order.Id = _orders.Max(o => o.Id) + 1;
        _orders.Add(order);
        return 1;
    }

    /// <inheritdoc />
    public int Update(Order order)
    {
        var index = _orders.FindIndex(o => o.Id == order.Id);
        if (index == -1) return 0;
        _orders[index] = order;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        if (order == null) return 0;
        _orders.Remove(order);
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
