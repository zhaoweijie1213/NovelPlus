using System.Collections.Generic;
using FileService.Service.Domain.Entities;

namespace FileService.Service.Application;

/// <summary>
/// 文件业务接口
/// </summary>
public interface IFileService
{
    /// <summary>
    /// 获取文件列表
    /// </summary>
    IEnumerable<FileRecord> GetAll();
}
