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
    
    
    public class meth_payMap : BaseEntityTypeConfiguration<HoteManagement.Domain.meth_pay>
    {
       public meth_payMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.meth_pay_name).HasMaxLength(50);
          this.Property(t => t.meth_is_ya);
          this.Property(t => t.meth_is_jie);
          this.Property(t => t.meth_sort);
          this.Property(t => t.remark).HasMaxLength();
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
