using System;
using SqlSugar;

namespace NovelPlus.Portal.Service.Domain.Entities;

/// <summary>
/// 网站信息表
/// </summary>
[SugarTable("website_info")]
public class WebsiteInfoEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 网站名
    /// </summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 网站域名
    /// </summary>
    [SugarColumn(ColumnName = "domain")]
    public string Domain { get; set; } = string.Empty;

    /// <summary>
    /// SEO关键词
    /// </summary>
    [SugarColumn(ColumnName = "keyword")]
    public string Keyword { get; set; } = string.Empty;

    /// <summary>
    /// 网站描述
    /// </summary>
    [SugarColumn(ColumnName = "description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 站长QQ
    /// </summary>
    [SugarColumn(ColumnName = "qq")]
    public string Qq { get; set; } = string.Empty;

    /// <summary>
    /// 网站logo图片（默认）
    /// </summary>
    [SugarColumn(ColumnName = "logo")]
    public string Logo { get; set; } = string.Empty;

    /// <summary>
    /// 网站logo图片（深色）
    /// </summary>
    [SugarColumn(ColumnName = "logo_dark")]
    public string LogoDark { get; set; } = string.Empty;

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
