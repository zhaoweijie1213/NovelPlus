using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 代码生成表列
    ///</summary>
    [SugarTable("sys_gen_table_column")]
    public class SysGenTableColumnEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true   )]
         public long Id { get; set; }
         
        /// <summary>
        /// 表id 
        ///</summary>
         [SugarColumn(ColumnName="table_id"    )]
         public long TableId { get; set; }
         
        /// <summary>
        /// 列名 
        ///</summary>
         [SugarColumn(ColumnName="column_name"    )]
         public string ColumnName { get; set; }
         
        /// <summary>
        /// 列排序（升序） 
        ///</summary>
         [SugarColumn(ColumnName="column_sort"    )]
         public decimal? ColumnSort { get; set; }
         
        /// <summary>
        /// 类型 
        ///</summary>
         [SugarColumn(ColumnName="column_type"    )]
         public string ColumnType { get; set; }
         
        /// <summary>
        /// 列标签名 
        ///</summary>
         [SugarColumn(ColumnName="column_label"    )]
         public string ColumnLabel { get; set; }
         
        /// <summary>
        /// 列备注说明 
        ///</summary>
         [SugarColumn(ColumnName="comments"    )]
         public string Comments { get; set; }
         
        /// <summary>
        /// 类的属性名 
        ///</summary>
         [SugarColumn(ColumnName="attr_name"    )]
         public string AttrName { get; set; }
         
        /// <summary>
        /// 类的属性类型 
        ///</summary>
         [SugarColumn(ColumnName="attr_type"    )]
         public string AttrType { get; set; }
         
        /// <summary>
        /// 是否主键 
        ///</summary>
         [SugarColumn(ColumnName="is_pk"    )]
         public string IsPk { get; set; }
         
        /// <summary>
        /// 是否可为空 
        ///</summary>
         [SugarColumn(ColumnName="is_null"    )]
         public string IsNull { get; set; }
         
        /// <summary>
        /// 是否插入字段 
        ///</summary>
         [SugarColumn(ColumnName="is_insert"    )]
         public string IsInsert { get; set; }
         
        /// <summary>
        /// 是否更新字段 
        ///</summary>
         [SugarColumn(ColumnName="is_update"    )]
         public string IsUpdate { get; set; }
         
        /// <summary>
        /// 是否列表字段 
        ///</summary>
         [SugarColumn(ColumnName="is_list"    )]
         public string IsList { get; set; }
         
        /// <summary>
        /// 是否查询字段 
        ///</summary>
         [SugarColumn(ColumnName="is_query"    )]
         public string IsQuery { get; set; }
         
        /// <summary>
        /// 查询方式 
        ///</summary>
         [SugarColumn(ColumnName="query_type"    )]
         public string QueryType { get; set; }
         
        /// <summary>
        /// 是否编辑字段 
        ///</summary>
         [SugarColumn(ColumnName="is_edit"    )]
         public string IsEdit { get; set; }
         
        /// <summary>
        /// 表单类型 
        ///</summary>
         [SugarColumn(ColumnName="show_type"    )]
         public string ShowType { get; set; }
         
        /// <summary>
        /// 其它生成选项 
        ///</summary>
         [SugarColumn(ColumnName="options"    )]
         public string Options { get; set; }
         
    }
}
