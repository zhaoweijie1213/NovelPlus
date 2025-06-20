using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;
/// <summary>
/// 数据权限管理
///</summary>
[SugarTable("sys_data_perm")]
public class SysDataPermEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 权限名称 
    ///</summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 数据表名称 
    ///</summary>
    [SugarColumn(ColumnName = "table_name")]
    public string TableName { get; set; } = string.Empty;

    /// <summary>
    /// 所属模块 
    ///</summary>
    [SugarColumn(ColumnName = "module_name")]
    public string ModuleName { get; set; } = string.Empty;

    /// <summary>
    /// 用户权限控制属性名 
    ///</summary>
    [SugarColumn(ColumnName = "crl_attr_name")]
    public string CrlAttrName { get; set; } = string.Empty;

    /// <summary>
    /// 数据表权限控制列名 
    ///</summary>
    [SugarColumn(ColumnName = "crl_column_name")]
    public string CrlColumnName { get; set; } = string.Empty;

    /// <summary>
    /// 权限code，all_开头表示查看所有数据的权限，sup_开头表示查看下级数据的权限，own_开头表示查看本级数据的权限 
    ///</summary>
    [SugarColumn(ColumnName = "perm_code")]
    public string PermCode { get; set; } = string.Empty;

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
