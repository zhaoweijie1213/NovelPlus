using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 用户与角色对应关系
    ///</summary>
    [SugarTable("sys_user_role")]
    public class SysUserRoleEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 用户ID 
        ///</summary>
         [SugarColumn(ColumnName="user_id"    )]
         public long? UserId { get; set; }
         
        /// <summary>
        /// 角色ID 
        ///</summary>
         [SugarColumn(ColumnName="role_id"    )]
         public long? RoleId { get; set; }
         
    }
}
