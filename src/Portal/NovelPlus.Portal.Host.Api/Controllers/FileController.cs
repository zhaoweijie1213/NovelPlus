using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using NovelPlus.Portal.Service.Application.Interfaces;
using QYQ.Base.Common.ApiResult;

namespace NovelPlus.Portal.Host.Api.Controllers;

/// <summary>
/// 文件接口
/// </summary>
[Route("/api/v{version:apiVersion}/[controller]")]
[Route("/api/[controller]")]
[ApiController]
[ApiVersion("1")]
[ApiExplorerSettings(GroupName = "v1")]
public class FileController(IFileService service) : ControllerBase
{
    private readonly IFileService _service = service;

    /// <summary>
    /// 转存图片
    /// </summary>
    [HttpPost("TransFile")]
    public Task<ApiResult<string>> TransFileAsync()
    {
        var result = new ApiResult<string>().SetRsult(ApiResultCode.Success, string.Empty);
        return Task.FromResult(result);
    }
}
