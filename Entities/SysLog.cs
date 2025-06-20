using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 系统日志
    ///</summary>
    [SugarTable("sys_log")]
    public class SysLogEntity
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 用户id 
        ///</summary>
         [SugarColumn(ColumnName="user_id"    )]
         public long? UserId { get; set; }
         
        /// <summary>
        /// 用户名 
        ///</summary>
         [SugarColumn(ColumnName="username"    )]
         public string Username { get; set; }
         
        /// <summary>
        /// 用户操作 
        ///</summary>
         [SugarColumn(ColumnName="operation"    )]
         public string Operation { get; set; }
         
        /// <summary>
        /// 响应时间 
        ///</summary>
         [SugarColumn(ColumnName="time"    )]
         public int? Time { get; set; }
         
        /// <summary>
        /// 请求方法 
        ///</summary>
         [SugarColumn(ColumnName="method"    )]
         public string Method { get; set; }
         
        /// <summary>
        /// 请求参数 
        ///</summary>
         [SugarColumn(ColumnName="params"    )]
         public string Params { get; set; }
         
        /// <summary>
        /// IP地址 
        ///</summary>
         [SugarColumn(ColumnName="ip"    )]
         public string Ip { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="gmt_create"    )]
         public DateTime? GmtCreate { get; set; }
         
    }
}
