using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 小说弹幕表
    ///</summary>
    [SugarTable("book_screen_bullet")]
    public class BookScreenBulletEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 小说内容ID 
        ///</summary>
         [SugarColumn(ColumnName="content_id"    )]
         public long ContentId { get; set; }
         
        /// <summary>
        /// 小说弹幕内容 
        ///</summary>
         [SugarColumn(ColumnName="screen_bullet"    )]
         public string ScreenBullet { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime CreateTime { get; set; }
         
    }
}
