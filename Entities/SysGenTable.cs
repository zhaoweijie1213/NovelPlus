using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 代码生成表
    ///</summary>
    [SugarTable("sys_gen_table")]
    public class SysGenTableEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true   )]
         public long Id { get; set; }
         
        /// <summary>
        /// 表名 
        ///</summary>
         [SugarColumn(ColumnName="table_name"    )]
         public string TableName { get; set; }
         
        /// <summary>
        /// 实体类名称 
        ///</summary>
         [SugarColumn(ColumnName="class_name"    )]
         public string ClassName { get; set; }
         
        /// <summary>
        /// 表说明 
        ///</summary>
         [SugarColumn(ColumnName="comments"    )]
         public string Comments { get; set; }
         
        /// <summary>
        /// 分类：0：数据表，1：树表 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="category"    )]
         public byte Category { get; set; }
         
        /// <summary>
        /// 生成包路径 
        ///</summary>
         [SugarColumn(ColumnName="package_name"    )]
         public string PackageName { get; set; }
         
        /// <summary>
        /// 生成模块名 
        ///</summary>
         [SugarColumn(ColumnName="module_name"    )]
         public string ModuleName { get; set; }
         
        /// <summary>
        /// 生成子模块名 
        ///</summary>
         [SugarColumn(ColumnName="sub_module_name"    )]
         public string SubModuleName { get; set; }
         
        /// <summary>
        /// 生成功能名，用于类描述 
        ///</summary>
         [SugarColumn(ColumnName="function_name"    )]
         public string FunctionName { get; set; }
         
        /// <summary>
        /// 生成功能名（简写），用于功能提示，如“保存xx成功” 
        ///</summary>
         [SugarColumn(ColumnName="function_name_simple"    )]
         public string FunctionNameSimple { get; set; }
         
        /// <summary>
        /// 生成功能作者 
        ///</summary>
         [SugarColumn(ColumnName="author"    )]
         public string Author { get; set; }
         
        /// <summary>
        /// src目录 
        ///</summary>
         [SugarColumn(ColumnName="src_dir"    )]
         public string SrcDir { get; set; }
         
        /// <summary>
        /// 其它生成选项 
        ///</summary>
         [SugarColumn(ColumnName="options"    )]
         public string Options { get; set; }
         
        /// <summary>
        /// 创建者 
        ///</summary>
         [SugarColumn(ColumnName="create_by"    )]
         public long CreateBy { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_date"    )]
         public DateTime CreateDate { get; set; }
         
        /// <summary>
        /// 更新者 
        ///</summary>
         [SugarColumn(ColumnName="update_by"    )]
         public long UpdateBy { get; set; }
         
        /// <summary>
        /// 更新时间 
        ///</summary>
         [SugarColumn(ColumnName="update_date"    )]
         public DateTime UpdateDate { get; set; }
         
        /// <summary>
        /// 备注信息 
        ///</summary>
         [SugarColumn(ColumnName="remarks"    )]
         public string Remarks { get; set; }
         
    }
}
