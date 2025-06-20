using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 稿费收入明细统计表
    ///</summary>
    [SugarTable("author_income_detail")]
    public class AuthorIncomeDetailEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 用户ID 
        ///</summary>
         [SugarColumn(ColumnName="user_id"    )]
         public long UserId { get; set; }
         
        /// <summary>
        /// 作家ID 
        ///</summary>
         [SugarColumn(ColumnName="author_id"    )]
         public long AuthorId { get; set; }
         
        /// <summary>
        /// 作品ID,0表示全部作品 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="book_id"    )]
         public long BookId { get; set; }
         
        /// <summary>
        /// 收入日期 
        ///</summary>
         [SugarColumn(ColumnName="income_date"    )]
         public DateTime IncomeDate { get; set; }
         
        /// <summary>
        /// 订阅总额 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="income_account"    )]
         public int IncomeAccount { get; set; }
         
        /// <summary>
        /// 订阅次数 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="income_count"    )]
         public int IncomeCount { get; set; }
         
        /// <summary>
        /// 订阅人数 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="income_number"    )]
         public int IncomeNumber { get; set; }
         
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime? CreateTime { get; set; }
         
    }
}
