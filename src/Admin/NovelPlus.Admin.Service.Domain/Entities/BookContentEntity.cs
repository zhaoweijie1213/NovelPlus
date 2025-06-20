using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 小说内容表
/// </summary>
[SugarTable("book_content")]
public class BookContentEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 目录ID
    /// </summary>
    [SugarColumn(ColumnName = "index_id")]
    public long? IndexId { get; set; }

    /// <summary>
    /// 小说章节内容
    /// </summary>
    [SugarColumn(ColumnName = "content")]
    public string Content { get; set; } = string.Empty;
}
