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
    
    
    public class customerTypeMap : BaseEntityTypeConfiguration<HoteManagement.Domain.customerType>
    {
       public customerTypeMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.ctName).HasMaxLength(50);
          this.Property(t => t.Reamrk).HasMaxLength(50);
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}