using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 文件上传
/// </summary>
[SugarTable("sys_file")]
public class SysFileEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 文件类型
    /// </summary>
    [SugarColumn(ColumnName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// URL地址
    /// </summary>
    [SugarColumn(ColumnName = "url")]
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_date")]
    public DateTime? CreateDate { get; set; }
}
