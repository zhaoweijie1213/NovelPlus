using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 用户信息
/// </summary>
[SugarTable("user")]
public class UserEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    [SugarColumn(ColumnName = "username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// 登录密码
    /// </summary>
    [SugarColumn(ColumnName = "password")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 昵称
    /// </summary>
    [SugarColumn(ColumnName = "nick_name")]
    public string NickName { get; set; } = string.Empty;

    /// <summary>
    /// 用户头像
    /// </summary>
    [SugarColumn(ColumnName = "user_photo")]
    public string UserPhoto { get; set; } = string.Empty;

    /// <summary>
    /// 性别
    /// </summary>
    [SugarColumn(ColumnName = "user_sex")]
    public byte? UserSex { get; set; }

    /// <summary>
    /// 账户余额
    /// </summary>
    [SugarColumn(ColumnName = "account_balance")]
    public long AccountBalance { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [SugarColumn(ColumnName = "status")]
    public byte Status { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_time")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [SugarColumn(ColumnName = "update_time")]
    public DateTime UpdateTime { get; set; }
}
