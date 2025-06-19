using System;
using System.Collections.Generic;
using FileService.Service.Domain.Entities;

namespace FileService.Service.Application;

/// <summary>
/// 文件业务接口
/// </summary>
public interface IFileService
{
    /// <summary>
    /// 获取全部文件
    /// </summary>
    IEnumerable<FileRecord> GetAll();

    /// <summary>
    /// 根据ID获取文件
    /// </summary>
    FileRecord? GetById(long id);

    /// <summary>
    /// 条件查询文件
    /// </summary>
    IEnumerable<FileRecord> List(IDictionary<string, object> filters);

    /// <summary>
    /// 查询数量
    /// </summary>
    int Count(IDictionary<string, object> filters);

    /// <summary>
    /// 保存文件
    /// </summary>
    int Save(FileRecord file);

    /// <summary>
    /// 更新文件
    /// </summary>
    int Update(FileRecord file);

    /// <summary>
    /// 删除文件
    /// </summary>
    int Remove(long id);

    /// <summary>
    /// 批量删除文件
    /// </summary>
    int BatchRemove(long[] ids);

    /// <summary>
    /// 表统计
    /// </summary>
    IDictionary<object, object> TableStat(DateTime minDate);
}
