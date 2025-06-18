using System.Collections.Generic;
using FileService.Service.Domain.Entities;

namespace FileService.Service.Application;

/// <summary>
/// 文件业务实现
/// </summary>
public class FileService : IFileService
{
    /// <summary>
    /// 示例文件列表
    /// </summary>
    private readonly List<FileRecord> _files = new()
    {
        new FileRecord { Id = 1, FileName = "demo.txt" }
    };

    /// <inheritdoc />
    public IEnumerable<FileRecord> GetAll() => _files;
}
