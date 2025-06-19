namespace FileService.Service.Application;

using System;
using System.Collections.Generic;
using global::FileService.Service.Domain.Entities;

/// <summary>
/// 文件仓储接口
/// </summary>
public interface IFileRecordRepository
{
    /// <summary>
    /// 根据ID获取文件
    /// </summary>
    FileRecord? Get(long id);

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
