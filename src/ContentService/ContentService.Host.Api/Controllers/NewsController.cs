using System.Collections.Generic;
using ContentService.Service.Application;
using ContentService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ContentService.Host.Api.Controllers;

/// <summary>
/// 新闻接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    private readonly IContentService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public NewsController(IContentService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取新闻列表
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<News>> GetAll()
    {
        return Ok(_service.GetAll());
    }
}
