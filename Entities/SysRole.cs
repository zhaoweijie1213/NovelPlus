using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 角色
    ///</summary>
    [SugarTable("sys_role")]
    public class SysRoleEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="role_id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long RoleId { get; set; }
         
        /// <summary>
        /// 角色名称 
        ///</summary>
         [SugarColumn(ColumnName="role_name"    )]
         public string RoleName { get; set; }
         
        /// <summary>
        /// 角色标识 
        ///</summary>
         [SugarColumn(ColumnName="role_sign"    )]
         public string RoleSign { get; set; }
         
        /// <summary>
        /// 备注 
        ///</summary>
         [SugarColumn(ColumnName="remark"    )]
         public string Remark { get; set; }
         
        /// <summary>
        /// 创建用户id 
        ///</summary>
         [SugarColumn(ColumnName="user_id_create"    )]
         public long? UserIdCreate { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="gmt_create"    )]
         public DateTime? GmtCreate { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="gmt_modified"    )]
         public DateTime? GmtModified { get; set; }
         
    }
}
