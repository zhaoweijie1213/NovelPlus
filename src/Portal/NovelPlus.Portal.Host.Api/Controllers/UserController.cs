using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Application.Output;
using NovelPlus.Portal.Service.Application.Input;
using NovelPlus.Portal.Service.Domain.Entities;
using Mapster;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 用户接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class UserController(IUserService service) : ControllerBase
{
    private readonly IUserService _service = service;

    /// <summary>
    /// 用户注册
    /// </summary>
    [HttpPost("Register")]
    public async Task<ApiResult<UserOutput?>> RegisterAsync([FromBody] UserInput input)
    {
        var entity = input.Adapt<UserEntity>();
        var user = await _service.RegisterAsync(entity);
        var output = user?.Adapt<UserOutput>();
        return new ApiResult<UserOutput?>().SetRsult(ApiResultCode.Success, output);
    }
}
