using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 文件上传
    ///</summary>
    [SugarTable("sys_file")]
    public class SysFileEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 文件类型 
        ///</summary>
         [SugarColumn(ColumnName="type"    )]
         public int? Type { get; set; }
         
        /// <summary>
        /// URL地址 
        ///</summary>
         [SugarColumn(ColumnName="url"    )]
         public string Url { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_date"    )]
         public DateTime? CreateDate { get; set; }
         
    }
}
