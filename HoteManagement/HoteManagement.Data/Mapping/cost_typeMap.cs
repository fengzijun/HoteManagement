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
    
    
    public class cost_typeMap : BaseEntityTypeConfiguration<HoteManagement.Domain.cost_type>
    {
       public cost_typeMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.ct_number).HasMaxLength(50);
          this.Property(t => t.ct_name).HasMaxLength(50);
          this.Property(t => t.ct_iftype);
          this.Property(t => t.ct_remark).HasMaxLength(null);
          this.Property(t => t.ct_money);
          this.Property(t => t.ct_categories);
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
