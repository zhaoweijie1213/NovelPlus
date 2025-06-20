using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 网站信息表
/// </summary>
[SugarTable("website_info")]
public class WebsiteInfoEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "domain")]
    public string Domain { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "keyword")]
    public string Keyword { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "description")]
    public string Description { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "qq")]
    public string Qq { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "logo")]
    public string Logo { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "logo_dark")]
    public string LogoDark { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }

    [SugarColumn(ColumnName = "create_user_id")]
    public long? CreateUserId { get; set; }

    [SugarColumn(ColumnName = "update_time")]
    public DateTime? UpdateTime { get; set; }

    [SugarColumn(ColumnName = "update_user_id")]
    public long? UpdateUserId { get; set; }
}
