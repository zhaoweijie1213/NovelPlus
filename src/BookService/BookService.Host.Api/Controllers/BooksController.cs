using System.Collections.Generic;
using BookService.Service.Application;
using BookService.Service.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookService.Host.Api.Controllers;

/// <summary>
/// 书籍接口
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _service;

    /// <summary>
    /// 构造函数
    /// </summary>
    public BooksController(IBookService service)
    {
        _service = service;
    }

    /// <summary>
    /// 获取全部书籍
    /// </summary>
    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetAll()
    {
        return Ok(_service.GetAll());
    }

    /// <summary>
    /// 根据ID获取书籍
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<Book?> GetById(int id)
    {
        var book = _service.GetById(id);
        if (book == null) return NotFound();
        return Ok(book);
    }
}
