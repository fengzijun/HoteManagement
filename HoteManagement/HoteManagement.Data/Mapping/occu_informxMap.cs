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
    
    
    public class occu_informxMap : BaseEntityTypeConfiguration<HoteManagement.Domain.occu_informx>
    {
       public occu_informxMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.occ_no).HasMaxLength(50);
          this.Property(t => t.order_id);
          this.Property(t => t.occ_name).HasMaxLength(20);
          this.Property(t => t.occ_with).HasMaxLength(10);
          this.Property(t => t.real_type_id);
          this.Property(t => t.room_number).HasMaxLength(10);
          this.Property(t => t.real_scheme_id);
          this.Property(t => t.source_id);
          this.Property(t => t.mem_cardno).HasMaxLength(50);
          this.Property(t => t.real_mode_id);
          this.Property(t => t.real_price);
          this.Property(t => t.occ_time);
          this.Property(t => t.stay_day);
          this.Property(t => t.stay_deposit);
          this.Property(t => t.depar_time);
          this.Property(t => t.pha_sched);
          this.Property(t => t.card_id);
          this.Property(t => t.card_no).HasMaxLength(50);
          this.Property(t => t.brithday).HasMaxLength(20);
          this.Property(t => t.sex).HasMaxLength(1);
          this.Property(t => t.family_name).HasMaxLength(20);
          this.Property(t => t.address).HasMaxLength(50);
          this.Property(t => t.state_id);
          this.Property(t => t.deposit);
          this.Property(t => t.amount_money);
          this.Property(t => t.sort).HasMaxLength(50);
          this.Property(t => t.lordRoomid).HasMaxLength(50);
          this.Property(t => t.continuelive);
          this.Property(t => t.phonenum).HasMaxLength(50);
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
