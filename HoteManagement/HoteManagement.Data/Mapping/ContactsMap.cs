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
    
    
    public class ContactsMap : BaseEntityTypeConfiguration<HoteManagement.Domain.Contacts>
    {
       public ContactsMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.hotelid);
          this.Property(t => t.Accounts).HasMaxLength(50);
          this.Property(t => t.cName).HasMaxLength(50);
          this.Property(t => t.Sex);
          this.Property(t => t.Bearthday);
          this.Property(t => t.editUser).HasMaxLength(50);
          this.Property(t => t.addDatetime);
          this.Property(t => t.Appellation);
          this.Property(t => t.department);
          this.Property(t => t.officPhone).HasMaxLength(50);
          this.Property(t => t.Phone).HasMaxLength(50);
          this.Property(t => t.Address).HasMaxLength(50);
          this.Property(t => t.zipcode).HasMaxLength(20);
          this.Property(t => t.Mail).HasMaxLength(20);
          this.Property(t => t.familyPhone).HasMaxLength(20);
          this.Property(t => t.Likes).HasMaxLength(100);
          this.Property(t => t.Remark).HasMaxLength(500);
          this.Property(t => t.Post);
          this.HasRequired(t => t.UserHotel).WithMany().HasForeignKey(t => t.hotelid);
       }
    }
}
