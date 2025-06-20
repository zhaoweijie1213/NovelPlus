using System;
using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 字典表
/// </summary>
[SugarTable("sys_dict")]
public class SysDictEntity
{
    /// <summary>
    /// 编号
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 标签名
    /// </summary>
    [SugarColumn(ColumnName = "name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 数据值
    /// </summary>
    [SugarColumn(ColumnName = "value")]
    public string Value { get; set; } = string.Empty;

    /// <summary>
    /// 类型
    /// </summary>
    [SugarColumn(ColumnName = "type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// 描述
    /// </summary>
    [SugarColumn(ColumnName = "description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 排序（升序）
    /// </summary>
    [SugarColumn(ColumnName = "sort")]
    public decimal? Sort { get; set; }

    /// <summary>
    /// 父级编号
    /// 默认值: 0
    /// </summary>
    [SugarColumn(ColumnName = "parent_id")]
    public long? ParentId { get; set; }

    /// <summary>
    /// 创建者
    /// </summary>
    [SugarColumn(ColumnName = "create_by")]
    public int? CreateBy { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [SugarColumn(ColumnName = "create_date")]
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// 更新者
    /// </summary>
    [SugarColumn(ColumnName = "update_by")]
    public long? UpdateBy { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [SugarColumn(ColumnName = "update_date")]
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// 备注信息
    /// </summary>
    [SugarColumn(ColumnName = "remarks")]
    public string Remarks { get; set; } = string.Empty;

    /// <summary>
    /// 删除标记
    /// 默认值: 0
    /// </summary>
    [SugarColumn(ColumnName = "del_flag")]
    public string DelFlag { get; set; } = string.Empty;
}
