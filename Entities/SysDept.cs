using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 部门管理
    ///</summary>
    [SugarTable("sys_dept")]
    public class SysDeptEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="dept_id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long DeptId { get; set; }
         
        /// <summary>
        /// 上级部门ID，一级部门为0 
        ///</summary>
         [SugarColumn(ColumnName="parent_id"    )]
         public long? ParentId { get; set; }
         
        /// <summary>
        /// 部门名称 
        ///</summary>
         [SugarColumn(ColumnName="name"    )]
         public string Name { get; set; }
         
        /// <summary>
        /// 排序 
        ///</summary>
         [SugarColumn(ColumnName="order_num"    )]
         public int? OrderNum { get; set; }
         
        /// <summary>
        /// 是否删除  -1：已删除  0：正常 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="del_flag"    )]
         public byte? DelFlag { get; set; }
         
    }
}
