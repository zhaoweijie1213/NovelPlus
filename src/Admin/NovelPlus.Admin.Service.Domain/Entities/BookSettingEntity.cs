using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 首页小说设置表
/// </summary>
[SugarTable("book_setting")]
public class BookSettingEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 小说ID
    /// </summary>
    [SugarColumn(ColumnName = "book_id")]
    public long? BookId { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [SugarColumn(ColumnName = "sort")]
    public byte? Sort { get; set; }

    /// <summary>
    /// 首页类型
    /// </summary>
    [SugarColumn(ColumnName = "type")]
    public byte? Type { get; set; }

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
