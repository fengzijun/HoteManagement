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
    
    
    public class memberMap : BaseEntityTypeConfiguration<HoteManagement.Domain.member>
    {
       public memberMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.hotelid);
          this.Property(t => t.Mid).HasMaxLength(50);
          this.Property(t => t.Name).HasMaxLength(50);
          this.Property(t => t.Sex);
          this.Property(t => t.Zjtype);
          this.Property(t => t.ZjNumber).HasMaxLength(50);
          this.Property(t => t.Mtype);
          this.Property(t => t.sales);
          this.Property(t => t.Phone).HasMaxLength(50);
          this.Property(t => t.Baithday);
          this.Property(t => t.Pwd).HasMaxLength(50);
          this.Property(t => t.Likes).HasMaxLength(500);
          this.Property(t => t.Address).HasMaxLength(100);
          this.Property(t => t.Ramrek).HasMaxLength(500);
          this.Property(t => t.Integration);
          this.Property(t => t.IntegraDh);
          this.Property(t => t.IntegraDj);
          this.Property(t => t.Stored);
          this.Property(t => t.Statid);
          this.Property(t => t.AddDate);
          this.Property(t => t.addUser).HasMaxLength(50);
          this.Property(t => t.XqTime);
          this.HasRequired(t => t.UserHotel).WithMany().HasForeignKey(t => t.hotelid);
       }
    }
}
