using System;
using System.Collections.Generic;
using System.Linq;
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
        new FileRecord { Id = 1, Url = "demo.txt", Type = 0, CreateDate = DateTime.Now }
    };

    /// <inheritdoc />
    public IEnumerable<FileRecord> GetAll() => _files;

    /// <inheritdoc />
    public FileRecord? GetById(long id) => _files.FirstOrDefault(f => f.Id == id);

    /// <inheritdoc />
    public IEnumerable<FileRecord> List(IDictionary<string, object> filters) => _files;

    /// <inheritdoc />
    public int Count(IDictionary<string, object> filters) => _files.Count;

    /// <inheritdoc />
    public int Save(FileRecord file)
    {
        file.Id = _files.Max(f => f.Id) + 1;
        _files.Add(file);
        return 1;
    }

    /// <inheritdoc />
    public int Update(FileRecord file)
    {
        var index = _files.FindIndex(f => f.Id == file.Id);
        if (index == -1) return 0;
        _files[index] = file;
        return 1;
    }

    /// <inheritdoc />
    public int Remove(long id)
    {
        var file = _files.FirstOrDefault(f => f.Id == id);
        if (file == null) return 0;
        _files.Remove(file);
        return 1;
    }

    /// <inheritdoc />
    public int BatchRemove(long[] ids)
    {
        var removed = 0;
        foreach (var id in ids) removed += Remove(id);
        return removed;
    }

    /// <inheritdoc />
    public IDictionary<object, object> TableStat(DateTime minDate)
    {
        return new Dictionary<object, object>();
    }
}
