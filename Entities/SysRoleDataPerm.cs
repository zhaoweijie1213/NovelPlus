using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 角色与数据权限对应关系
    ///</summary>
    [SugarTable("sys_role_data_perm")]
    public class SysRoleDataPermEntity
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
        /// 权限ID 
        ///</summary>
         [SugarColumn(ColumnName="perm_id"    )]
         public long? PermId { get; set; }
         
    }
}
