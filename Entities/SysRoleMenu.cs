using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 角色与菜单对应关系
    ///</summary>
    [SugarTable("sys_role_menu")]
    public class SysRoleMenuEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 角色ID 
        ///</summary>
         [SugarColumn(ColumnName="role_id"    )]
         public long? RoleId { get; set; }
         
        /// <summary>
        /// 菜单ID 
        ///</summary>
         [SugarColumn(ColumnName="menu_id"    )]
         public long? MenuId { get; set; }
         
    }
}
