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

namespace HoteManagement.Console.Model
{
    
    
    public class RepairMap : BaseEntityTypeConfiguration<HoteManagement.Domain.Repair>
    {
       public RepairMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.repair_name).HasMaxLength(50);
          this.Property(t => t.repair_time);
          this.Property(t => t.repair_man).HasMaxLength(50);
          this.Property(t => t.repair_num);
          this.Property(t => t.repair_remark).HasMaxLength();
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
