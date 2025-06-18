using System.Collections.Generic;
using AuthorService.Service.Application;
using AuthorService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuthorService.Host.Api.Controllers;

/// <summary>
/// 作家接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly IAuthorService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public AuthorsController(IAuthorService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取全部作家
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Author>> GetAll()
    {
        return Ok(_service.GetAll());
    }
}
