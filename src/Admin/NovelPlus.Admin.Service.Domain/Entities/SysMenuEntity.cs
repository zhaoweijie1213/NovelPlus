using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;
/// <summary>
/// 菜单管理
///</summary>
[SugarTable("sys_menu")]
public class SysMenuEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "menu_id", IsPrimaryKey = true, IsIdentity = true)]
    public long MenuId { get; set; }

    /// <summary>
    /// 父菜单ID，一级菜单为0 
    ///</summary>
    [SugarColumn(ColumnName = "parent_id")]
    public long? ParentId { get; set; }

    /// <summary>
    /// 菜单名称 
    ///</summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 菜单URL 
    ///</summary>
    [SugarColumn(ColumnName = "url")]
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// 授权(多个用逗号分隔，如：user:list,user:create) 
    ///</summary>
    [SugarColumn(ColumnName = "perms")]
    public string Perms { get; set; } = string.Empty;

    /// <summary>
    /// 类型   0：目录   1：菜单   2：按钮 
    ///</summary>
    [SugarColumn(ColumnName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// 菜单图标 
    ///</summary>
    [SugarColumn(ColumnName = "icon")]
    public string Icon { get; set; } = string.Empty;

    /// <summary>
    /// 排序 
    ///</summary>
    [SugarColumn(ColumnName = "order_num")]
    public int? OrderNum { get; set; }

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

}
