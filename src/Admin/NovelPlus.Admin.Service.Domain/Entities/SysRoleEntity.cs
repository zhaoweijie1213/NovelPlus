using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;
/// <summary>
/// 角色
///</summary>
[SugarTable("sys_role")]
public class SysRoleEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "role_id", IsPrimaryKey = true, IsIdentity = true)]
    public long RoleId { get; set; }

    /// <summary>
    /// 角色名称 
    ///</summary>
    [SugarColumn(ColumnName = "role_name")]
    public string RoleName { get; set; } = string.Empty;

    /// <summary>
    /// 角色标识 
    ///</summary>
    [SugarColumn(ColumnName = "role_sign")]
    public string RoleSign { get; set; } = string.Empty;

    /// <summary>
    /// 备注 
    ///</summary>
    [SugarColumn(ColumnName = "remark")]
    public string Remark { get; set; } = string.Empty;

    /// <summary>
    /// 创建用户id 
    ///</summary>
    [SugarColumn(ColumnName = "user_id_create")]
    public long? UserIdCreate { get; set; }

    /// <summary>
    /// 创建时间 
    ///</summary>
    [SugarColumn(ColumnName = "gmt_create")]
    public DateTime? GmtCreate { get; set; }

    /// <summary>
    /// 创建时间 
    ///</summary>
    [SugarColumn(ColumnName = "gmt_modified")]
    public DateTime? GmtModified { get; set; }

}
