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
    
    
    public class ZD_hourseMap : BaseEntityTypeConfiguration<HoteManagement.Domain.ZD_hourse>
    {
       public ZD_hourseMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.latest);
          this.Property(t => t.Buffer);
          this.Property(t => t.tixing);
          this.Property(t => t.beigin);
          this.Property(t => t.endtime);
       }
    }
}
