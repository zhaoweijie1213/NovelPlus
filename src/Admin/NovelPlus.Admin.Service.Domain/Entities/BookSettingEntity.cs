using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 首页小说设置表
/// </summary>
[SugarTable("book_setting")]
public class BookSettingEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "book_id")]
    public long? BookId { get; set; }

    [SugarColumn(ColumnName = "sort")]
    public byte? Sort { get; set; }

    [SugarColumn(ColumnName = "type")]
    public byte? Type { get; set; }

    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }

    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }

    [SugarColumn(ColumnName = "update_user_id")]
    public long? UpdateUserId { get; set; }
}
