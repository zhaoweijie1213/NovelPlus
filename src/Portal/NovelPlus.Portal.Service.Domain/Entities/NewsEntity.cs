using System;
using SqlSugar;

namespace NovelPlus.Portal.Service.Domain.Entities;

/// <summary>
/// 新闻表
/// </summary>
[SugarTable("news")]
public class NewsEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 分类ID
    /// </summary>
    [SugarColumn(ColumnName = "cat_id")]
    public int? CatId { get; set; }

    /// <summary>
    /// 分类名称
    /// </summary>
    [SugarColumn(ColumnName = "cat_name")]
    public string CatName { get; set; } = string.Empty;

    /// <summary>
    /// 新闻来源
    /// </summary>
    [SugarColumn(ColumnName = "source_name")]
    public string SourceName { get; set; } = string.Empty;

    /// <summary>
    /// 标题
    /// </summary>
    [SugarColumn(ColumnName = "title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 正文内容
    /// </summary>
    [SugarColumn(ColumnName = "content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 阅读次数
    /// </summary>
    [SugarColumn(ColumnName = "read_count")]
    public long ReadCount { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 更新人ID
    /// </summary>
    [SugarColumn(ColumnName = "update_user_id")]
    public long? UpdateUserId { get; set; }
}
