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
    /// <param name="id">订单ID</param>
    /// <returns>订单实体</returns>
    Order? GetById(int id);
}
