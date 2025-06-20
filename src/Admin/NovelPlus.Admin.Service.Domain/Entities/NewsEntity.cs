using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 新闻表
/// </summary>
[SugarTable("news")]
public class NewsEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "cat_id")]
    public int? CatId { get; set; }

    [SugarColumn(ColumnName = "cat_name")]
    public string CatName { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "source_name")]
    public string SourceName { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "title")]
    public string Title { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "content")]
    public string Content { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "read_count")]
    public long ReadCount { get; set; }

    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }

    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }

    [SugarColumn(ColumnName = "update_user_id")]
    public long? UpdateUserId { get; set; }
}
