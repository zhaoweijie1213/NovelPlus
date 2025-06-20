using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;
/// <summary>
/// 
///</summary>
[SugarTable("sys_user")]
public class SysUserEntity
{
    /// <summary>
    ///  
    ///</summary>
    [SugarColumn(ColumnName = "user_id", IsPrimaryKey = true, IsIdentity = true)]
    public long UserId { get; set; }

    /// <summary>
    /// 用户名 
    ///</summary>
    [SugarColumn(ColumnName = "username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    ///  
    ///</summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 密码 
    ///</summary>
    [SugarColumn(ColumnName = "password")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    ///  
    ///</summary>
    [SugarColumn(ColumnName = "dept_id")]
    public long? DeptId { get; set; }

    /// <summary>
    /// 邮箱 
    ///</summary>
    [SugarColumn(ColumnName = "email")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 手机号 
    ///</summary>
    [SugarColumn(ColumnName = "mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// 状态 0:禁用，1:正常 
    ///</summary>
    [SugarColumn(ColumnName = "status")]
    public byte? Status { get; set; }

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
    /// 修改时间 
    ///</summary>
    [SugarColumn(ColumnName = "gmt_modified")]
    public DateTime? GmtModified { get; set; }

    /// <summary>
    /// 性别 
    ///</summary>
    [SugarColumn(ColumnName = "sex")]
    public long? Sex { get; set; }

    /// <summary>
    /// 出身日期 
    ///</summary>
    [SugarColumn(ColumnName = "birth")]
    public DateTime? Birth { get; set; }

    /// <summary>
    ///  
    ///</summary>
    [SugarColumn(ColumnName = "pic_id")]
    public long? PicId { get; set; }

    /// <summary>
    /// 现居住地 
    ///</summary>
    [SugarColumn(ColumnName = "live_address")]
    public string LiveAddress { get; set; } = string.Empty;

    /// <summary>
    /// 爱好 
    ///</summary>
    [SugarColumn(ColumnName = "hobby")]
    public string Hobby { get; set; } = string.Empty;

    /// <summary>
    /// 省份 
    ///</summary>
    [SugarColumn(ColumnName = "province")]
    public string Province { get; set; } = string.Empty;

    /// <summary>
    /// 所在城市 
    ///</summary>
    [SugarColumn(ColumnName = "city")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// 所在地区 
    ///</summary>
    [SugarColumn(ColumnName = "district")]
    public string District { get; set; } = string.Empty;

}
