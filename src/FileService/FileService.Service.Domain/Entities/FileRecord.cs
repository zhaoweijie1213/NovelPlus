namespace FileService.Service.Domain.Entities;

using System;

/// <summary>
/// 文件记录实体
/// </summary>
public class FileRecord
{
    /// <summary>
    /// 主键
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 文件类型
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// URL地址
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateDate { get; set; }
}
