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
    
    
    public class book_roomMap : BaseEntityTypeConfiguration<HoteManagement.Domain.book_room>
    {
       public book_roomMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.hotelid);
          this.Property(t => t.book_no).HasMaxLength(20);
          this.Property(t => t.book_Name).HasMaxLength(20);
          this.Property(t => t.tele_no).HasMaxLength(20);
          this.Property(t => t.onli_no).HasMaxLength(20);
          this.Property(t => t.guar_way).HasMaxLength(20);
          this.Property(t => t.mem_cardno).HasMaxLength(50);
          this.Property(t => t.time_to);
          this.Property(t => t.time_from);
          this.Property(t => t.real_time);
          this.Property(t => t.source_id);
          this.Property(t => t.meth_pay_id);
          this.Property(t => t.deposit);
          this.Property(t => t.real_type_id);
          this.Property(t => t.real_scheme_id);
          this.Property(t => t.real_price);
          this.Property(t => t.state_id);
          this.Property(t => t.real_num);
          this.Property(t => t.remark);
          this.Property(t => t.room_number).HasMaxLength(20);
          this.Property(t => t.back_deposit);
          this.Property(t => t.userid).HasMaxLength(50);
          this.Property(t => t.Accounts).HasMaxLength(50);
          this.Property(t => t.CpID);
          this.HasRequired(t => t.UserHotel).WithMany().HasForeignKey(t => t.hotelid);
       }
    }
}
