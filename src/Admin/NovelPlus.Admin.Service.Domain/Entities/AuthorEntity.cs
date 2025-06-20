using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 作者表
/// </summary>
[SugarTable("author")]
public class AuthorEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    [SugarColumn(ColumnName = "user_id")]
    public long? UserId { get; set; }

    /// <summary>
    /// 邀请码
    /// </summary>
    [SugarColumn(ColumnName = "invite_code")]
    public string InviteCode { get; set; } = string.Empty;

    /// <summary>
    /// 笔名
    /// </summary>
    [SugarColumn(ColumnName = "pen_name")]
    public string PenName { get; set; } = string.Empty;

    /// <summary>
    /// 手机号码
    /// </summary>
    [SugarColumn(ColumnName = "tel_phone")]
    public string TelPhone { get; set; } = string.Empty;

    /// <summary>
    /// QQ或微信账号
    /// </summary>
    [SugarColumn(ColumnName = "chat_account")]
    public string ChatAccount { get; set; } = string.Empty;

    /// <summary>
    /// 电子邮箱
    /// </summary>
    [SugarColumn(ColumnName = "email")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 作品方向，0：男频，1：女频
    /// </summary>
    [SugarColumn(ColumnName = "work_direction")]
    public byte? WorkDirection { get; set; }

    /// <summary>
    /// 0：正常，1：封禁
    /// </summary>
    [SugarColumn(ColumnName = "status")]
    public byte? Status { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime? CreateTime { get; set; }
}
