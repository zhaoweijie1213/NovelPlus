﻿using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 作家邀请码表
    ///</summary>
    [SugarTable("author_code")]
    public class AuthorCodeEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 邀请码 
        ///</summary>
         [SugarColumn(ColumnName="invite_code"    )]
         public string InviteCode { get; set; }
         
        /// <summary>
        /// 有效时间 
        ///</summary>
         [SugarColumn(ColumnName="validity_time"    )]
         public DateTime? ValidityTime { get; set; }
         
        /// <summary>
        /// 是否使用过，0：未使用，1:使用过 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="is_use"    )]
         public byte? IsUse { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
        /// <summary>
        /// 创建人ID 
        ///</summary>
         [SugarColumn(ColumnName="create_user_id"    )]
         public long? CreateUserId { get; set; }
         
    }
}
