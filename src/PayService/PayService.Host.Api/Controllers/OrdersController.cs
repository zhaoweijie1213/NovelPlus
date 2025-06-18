using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PayService.Service.Application;
using PayService.Service.Domain.Entities;

namespace PayService.Host.Api.Controllers;

/// <summary>
/// 订单接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public OrdersController(IOrderService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取全部订单
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Order>> GetAll()
    {
        return Ok(_service.GetAll());
    }

    /// <summary>
    /// 根据ID获取订单
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<Order?> GetById(int id)
    {
        var order = _service.GetById(id);
        if (order == null) return NotFound();
        return Ok(order);
    }
}
