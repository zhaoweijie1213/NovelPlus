using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("friend_link")]
    public class FriendLinkEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
         
        /// <summary>
        /// 链接名 
        ///</summary>
         [SugarColumn(ColumnName="link_name"    )]
         public string LinkName { get; set; }
         
        /// <summary>
        /// 链接url 
        ///</summary>
         [SugarColumn(ColumnName="link_url"    )]
         public string LinkUrl { get; set; }
         
        /// <summary>
        /// 排序号 
        /// 默认值: 11
        ///</summary>
         [SugarColumn(ColumnName="sort"    )]
         public byte Sort { get; set; }
         
        /// <summary>
        /// 是否开启，0：不开启，1：开启 
        /// 默认值: 1
        ///</summary>
         [SugarColumn(ColumnName="is_open"    )]
         public byte IsOpen { get; set; }
         
        /// <summary>
        /// 创建人id 
        ///</summary>
         [SugarColumn(ColumnName="create_user_id"    )]
         public long? CreateUserId { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        /// 更新者用户id 
        ///</summary>
         [SugarColumn(ColumnName="update_user_id"    )]
         public long? UpdateUserId { get; set; }
         
        /// <summary>
        /// 更新时间 
        ///</summary>
         [SugarColumn(ColumnName="update_time"    )]
         public DateTime? UpdateTime { get; set; }
         
    }
}
