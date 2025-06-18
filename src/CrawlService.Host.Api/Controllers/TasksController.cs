using System.Collections.Generic;
using CrawlService.Service.Application;
using CrawlService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrawlService.Host.Api.Controllers;

/// <summary>
/// 爬虫任务接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly ISpiderService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public TasksController(ISpiderService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取全部爬虫任务
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<SpiderTask>> GetAll()
    {
        return Ok(_service.GetAll());
    }
}
