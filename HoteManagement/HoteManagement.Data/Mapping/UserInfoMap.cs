//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace HoteManagement.Data.Mapping
{
    
    
    public class UserInfoMap : BaseEntityTypeConfiguration<HoteManagement.Domain.UserInfo>
    {
       public UserInfoMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.userID).HasMaxLength(50);
          this.Property(t => t.cardID).HasMaxLength(10);
          this.Property(t => t.sex);
          this.Property(t => t.cardTypeID);
          this.Property(t => t.cardValue).HasMaxLength(50);
          this.Property(t => t.typeid);
          this.Property(t => t.xiaoshou).HasMaxLength(50);
          this.Property(t => t.phone).HasMaxLength(50);
          this.Property(t => t.bairthday);
          this.Property(t => t.xihao).HasMaxLength(100);
          this.Property(t => t.address).HasMaxLength(100);
          this.Property(t => t.meark);
          this.Property(t => t.manageID);
          this.Property(t => t.truename).HasMaxLength(50);
       }
    }
}
