using SqlSugar;

namespace NovelPlus.Admin.Service.Domain.Entities;

/// <summary>
/// 角色与菜单关系
/// </summary>
[SugarTable("sys_role_menu")]
public class SysRoleMenuEntity
{
    /// <summary>
    /// 主键
    /// </summary>
    [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
    public long Id { get; set; }

    /// <summary>
    /// 角色ID
    /// </summary>
    [SugarColumn(ColumnName = "role_id")]
    public long? RoleId { get; set; }

    /// <summary>
    /// 菜单ID
    /// </summary>
    [SugarColumn(ColumnName = "menu_id")]
    public long? MenuId { get; set; }
}
