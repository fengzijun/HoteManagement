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
    
    
    public class room_stateMap : BaseEntityTypeConfiguration<HoteManagement.Domain.room_state>
    {
       public room_stateMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.room_state_name).HasMaxLength(50);
          this.Property(t => t.Room_suod).HasMaxLength(10);
          this.Property(t => t.remark);
          this.Property(t => t.Room_color).HasMaxLength(50);
       }
    }
}
