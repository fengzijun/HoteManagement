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
    
    
    public class hour_roomMap : BaseEntityTypeConfiguration<HoteManagement.Domain.hour_room>
    {
       public hour_roomMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.hs_room_id);
          this.Property(t => t.hs_name).HasMaxLength(50);
          this.Property(t => t.hs_start_long).HasMaxLength(20);
          this.Property(t => t.hs_start_price);
          this.Property(t => t.hs_add_time).HasMaxLength(20);
          this.Property(t => t.hs_add_price);
          this.Property(t => t.hs_min_time).HasMaxLength(20);
          this.Property(t => t.hs_min_price);
          this.Property(t => t.hs_max_time).HasMaxLength(20);
          this.Property(t => t.hs_type_id);
          this.Property(t => t.hs_jgtype_id);
          this.Property(t => t.hs_source_id);
          this.Property(t => t.lostTime);
          this.Property(t => t.MtID);
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
