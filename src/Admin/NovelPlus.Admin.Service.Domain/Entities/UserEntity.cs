using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 用户信息
/// </summary>
[SugarTable("user")]
public class UserEntity
{
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "username")]
    public string Username { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "password")]
    public string Password { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "nick_name")]
    public string NickName { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "user_photo")]
    public string UserPhoto { get; set; } = string.Empty;

    [SugarColumn(ColumnName = "user_sex")]
    public byte? UserSex { get; set; }

    [SugarColumn(ColumnName = "account_balance")]
    public long AccountBalance { get; set; }

    [SugarColumn(ColumnName = "status")]
    public byte Status { get; set; }

    [SugarColumn(ColumnName = "create_time")]
    public DateTime CreateTime { get; set; }

    [SugarColumn(ColumnName = "update_time")]
    public DateTime UpdateTime { get; set; }
}
