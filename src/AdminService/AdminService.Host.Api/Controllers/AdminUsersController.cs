using System.Collections.Generic;
using AdminService.Service.Application;
using AdminService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Host.Api.Controllers;

/// <summary>
/// 管理员接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AdminUsersController : ControllerBase
{
    private readonly IAdminService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public AdminUsersController(IAdminService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取管理员列表
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<AdminUser>> GetAll()
    {
        return Ok(_service.GetAll());
    }
}
