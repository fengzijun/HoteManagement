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
    
    
    public class bannerMap : BaseEntityTypeConfiguration<HoteManagement.Domain.banner>
    {
       public bannerMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.banner_id).HasMaxLength(50);
          this.Property(t => t.title).HasMaxLength(100);
          this.Property(t => t.imgurl).HasMaxLength(200);
          this.Property(t => t.sortId);
          this.Property(t => t.pubdate);
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
