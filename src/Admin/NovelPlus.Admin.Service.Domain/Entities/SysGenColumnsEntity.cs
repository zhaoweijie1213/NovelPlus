using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 代码生成列
/// </summary>
[SugarTable("sys_gen_columns")]
public class SysGenColumnsEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 表名
    /// </summary>
    [SugarColumn(ColumnName = "table_name")]
    public string TableName { get; set; } = string.Empty;

    /// <summary>
    /// 列名
    /// </summary>
    [SugarColumn(ColumnName = "column_name")]
    public string ColumnName { get; set; } = string.Empty;

    /// <summary>
    /// 列类型
    /// </summary>
    [SugarColumn(ColumnName = "column_type")]
    public string ColumnType { get; set; } = string.Empty;

    /// <summary>
    /// 映射java类型
    /// </summary>
    [SugarColumn(ColumnName = "java_type")]
    public string JavaType { get; set; } = string.Empty;

    /// <summary>
    /// 列注释
    /// </summary>
    [SugarColumn(ColumnName = "column_comment")]
    public string ColumnComment { get; set; } = string.Empty;

    /// <summary>
    /// 列排序（升序）
    /// </summary>
    [SugarColumn(ColumnName = "column_sort")]
    public byte? ColumnSort { get; set; }

    /// <summary>
    /// 列标记名
    /// </summary>
    [SugarColumn(ColumnName = "column_label")]
    public string ColumnLabel { get; set; } = string.Empty;

    /// <summary>
    /// 页面显示类型
    /// </summary>
    [SugarColumn(ColumnName = "page_type")]
    public byte? PageType { get; set; }

    /// <summary>
    /// 是否必填
    /// </summary>
    [SugarColumn(ColumnName = "is_required")]
    public byte? IsRequired { get; set; }

    /// <summary>
    /// 页面显示为下拉时使用的字典类型
    /// </summary>
    [SugarColumn(ColumnName = "dict_type")]
    public string DictType { get; set; } = string.Empty;
}
