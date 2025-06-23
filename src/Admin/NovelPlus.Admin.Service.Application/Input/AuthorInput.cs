using System;

namespace NovelPlus.Admin.Service.Application.Input;

/// <summary>
/// 作者输入
/// </summary>
public class AuthorInput
{
    /// <summary>
    /// 主键，用于更新
    /// </summary>
    public long Id { get; set; }
    /// <summary>
    /// 用户ID
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// 邀请码
    /// </summary>
    public string InviteCode { get; set; } = string.Empty;

    /// <summary>
    /// 笔名
    /// </summary>
    public string PenName { get; set; } = string.Empty;

    /// <summary>
    /// 手机号码
    /// </summary>
    public string TelPhone { get; set; } = string.Empty;

    /// <summary>
    /// QQ或微信账号
    /// </summary>
    public string ChatAccount { get; set; } = string.Empty;

    /// <summary>
    /// 电子邮箱
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 作品方向，0：男频，1：女频
    /// </summary>
    public byte? WorkDirection { get; set; }

    /// <summary>
    /// 0：正常，1：封禁
    /// </summary>
    public byte? Status { get; set; }
}
