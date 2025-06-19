namespace AdminService.Service.Domain.Entities;

using System;
using System.Collections.Generic;

/// <summary>
/// 管理员实体
/// </summary>
public class AdminUser
{
    /// <summary>
    /// 主键
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// 用户真实姓名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 部门ID
    /// </summary>
    public long DeptId { get; set; }

    /// <summary>
    /// 下级部门ID列表
    /// </summary>
    public string SupDeptIds { get; set; } = string.Empty;

    /// <summary>
    /// 部门名称
    /// </summary>
    public string DeptName { get; set; } = string.Empty;

    /// <summary>
    /// 邮箱
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// 状态 0:禁用，1:正常
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 创建者ID
    /// </summary>
    public long UserIdCreate { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? GmtCreate { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? GmtModified { get; set; }

    /// <summary>
    /// 角色ID列表
    /// </summary>
    public List<long> RoleIds { get; set; } = new();

    /// <summary>
    /// 性别
    /// </summary>
    public long Sex { get; set; }

    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime? Birth { get; set; }

    /// <summary>
    /// 图片ID
    /// </summary>
    public long PicId { get; set; }

    /// <summary>
    /// 现居住地
    /// </summary>
    public string LiveAddress { get; set; } = string.Empty;

    /// <summary>
    /// 爱好
    /// </summary>
    public string Hobby { get; set; } = string.Empty;

    /// <summary>
    /// 省份
    /// </summary>
    public string Province { get; set; } = string.Empty;

    /// <summary>
    /// 城市
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// 地区
    /// </summary>
    public string District { get; set; } = string.Empty;
}
