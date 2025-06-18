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
        new Order { Id = 1, Amount = 9.9m }
    };

    /// <inheritdoc />
    public IEnumerable<Order> GetAll() => _orders;

    /// <inheritdoc />
    public Order? GetById(int id) => _orders.FirstOrDefault(o => o.Id == id);
}
