using System.Collections.Generic;
using FileService.Service.Application;
using FileService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FileService.Host.Api.Controllers;

/// <summary>
/// 文件接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class FilesController : ControllerBase
{
    private readonly IFileService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public FilesController(IFileService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取文件列表
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<FileRecord>> GetAll()
    {
        return Ok(_service.GetAll());
    }
}
