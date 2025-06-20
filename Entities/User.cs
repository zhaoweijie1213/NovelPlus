using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace WebFirst.Entities
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("user")]
    public class UserEntity
    {
        /// <summary>
        /// 主键 
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public long Id { get; set; }
         
        /// <summary>
        /// 登录名 
        ///</summary>
         [SugarColumn(ColumnName="username"    )]
         public string Username { get; set; }
         
        /// <summary>
        /// 登录密码 
        ///</summary>
         [SugarColumn(ColumnName="password"    )]
         public string Password { get; set; }
         
        /// <summary>
        /// 昵称 
        ///</summary>
         [SugarColumn(ColumnName="nick_name"    )]
         public string NickName { get; set; }
         
        /// <summary>
        /// 用户头像 
        ///</summary>
         [SugarColumn(ColumnName="user_photo"    )]
         public string UserPhoto { get; set; }
         
        /// <summary>
        /// 用户性别，0：男，1：女 
        ///</summary>
         [SugarColumn(ColumnName="user_sex"    )]
         public byte? UserSex { get; set; }
         
        /// <summary>
        /// 账户余额 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="account_balance"    )]
         public long AccountBalance { get; set; }
         
        /// <summary>
        /// 用户状态，0：正常 
        /// 默认值: 0
        ///</summary>
         [SugarColumn(ColumnName="status"    )]
         public byte Status { get; set; }
         
        /// <summary>
        /// 创建时间 
        ///</summary>
         [SugarColumn(ColumnName="create_time"    )]
         public DateTime CreateTime { get; set; }
         
        /// <summary>
        /// 更新时间 
        ///</summary>
         [SugarColumn(ColumnName="update_time"    )]
         public DateTime UpdateTime { get; set; }
         
    }
}
