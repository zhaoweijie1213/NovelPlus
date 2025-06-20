using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("sys_gen_columns")]
    public class SysGenColumnsEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 表名 
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="table_name"    )]
         public string TableName { get; set; }
         
        /// <summary>
        /// 列名 
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="column_name"    )]
         public string ColumnName { get; set; }
         
        /// <summary>
        /// 列类型 
        ///</summary>
         [SugarColumn(ColumnName="column_type"    )]
         public string ColumnType { get; set; }
         
        /// <summary>
        /// 映射java类型 
        ///</summary>
         [SugarColumn(ColumnName="java_type"    )]
         public string JavaType { get; set; }
         
        /// <summary>
        /// 列注释 
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="column_comment"    )]
         public string ColumnComment { get; set; }
         
        /// <summary>
        /// 列排序（升序） 
        ///</summary>
         [SugarColumn(ColumnName="column_sort"    )]
         public byte? ColumnSort { get; set; }
         
        /// <summary>
        /// 鍒楁爣绛惧悕 
        ///</summary>
         [SugarColumn(ColumnName="column_label"    )]
         public string ColumnLabel { get; set; }
         
        /// <summary>
        /// 页面显示类型：1、文本框 2、下拉框 3、数值4、日期 5、文本域6、富文本 7、上传图片【单文件】 8、上传图片【多文件】9、上传文件【单文件】 10、上传文件【多文件】11、隐藏域 12、不显示 
        /// 默认值: 1
        ///</summary>
         [SugarColumn(ColumnName="page_type"    )]
         public byte? PageType { get; set; }
         
        /// <summary>
        /// 是否必填 
        ///</summary>
         [SugarColumn(ColumnName="is_required"    )]
         public byte? IsRequired { get; set; }
         
        /// <summary>
        /// 页面显示为下拉时使用，字典类型从字典表中取出 
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="dict_type"    )]
         public string DictType { get; set; }
         
    }
}
