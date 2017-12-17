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
    
    
    public class goods_accountMap : BaseEntityTypeConfiguration<HoteManagement.Domain.goods_account>
    {
       public goods_accountMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.hotelid);
          this.Property(t => t.ga_name).HasMaxLength(50);
          this.Property(t => t.ga_number).HasMaxLength(50);
          this.Property(t => t.ga_roomNumber).HasMaxLength(50);
          this.Property(t => t.ga_unit).HasMaxLength(50);
          this.Property(t => t.ga_num);
          this.Property(t => t.ga_price);
          this.Property(t => t.ga_zffs_id);
          this.Property(t => t.ga_date);
          this.Property(t => t.ga_people).HasMaxLength(50);
          this.Property(t => t.ga_Type);
          this.Property(t => t.ga_sum_price);
          this.Property(t => t.ga_remker);
          this.Property(t => t.ga_occuid).HasMaxLength(50);
          this.Property(t => t.ga_sfacount).HasMaxLength(50);
          this.Property(t => t.ga_isjz);
          this.Property(t => t.ga_goodNo).HasMaxLength(50);
          this.Property(t => t.ga_isys);
          this.Property(t => t.ga_Account).HasMaxLength(50);
          this.Property(t => t.ga_jsfs);
          this.HasRequired(t => t.UserHotel).WithMany().HasForeignKey(t => t.hotelid);
       }
    }
}
