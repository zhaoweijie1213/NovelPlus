using System;
using SqlSugar;

namespace NovelPlus.Portal.Service.Domain.Entities;

/// <summary>
/// 小说类别表
/// </summary>
[SugarTable("book_category")]
public class BookCategoryEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; }

    /// <summary>
    /// 作品方向，0：男频，1：女频
    /// </summary>
    [SugarColumn(ColumnName = "work_direction")]
    public byte? WorkDirection { get; set; }

    /// <summary>
    /// 分类名
    /// </summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 排序
    /// </summary>
    [SugarColumn(ColumnName = "sort")]
    public byte Sort { get; set; }

    /// <summary>
    /// 创建人ID
    /// </summary>
    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新人ID
    /// </summary>
    [SugarColumn(ColumnName = "update_user_id")]
    public long? UpdateUserId { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }
}
