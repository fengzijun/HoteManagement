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
    
    
    public class customerMap : BaseEntityTypeConfiguration<HoteManagement.Domain.customer>
    {
       public customerMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.accounts).HasMaxLength(50);
          this.Property(t => t.cName).HasMaxLength(50);
          this.Property(t => t.sysType);
          this.Property(t => t.cusType);
          this.Property(t => t.cusDesy).HasMaxLength(50);
          this.Property(t => t.cusNumber).HasMaxLength(50);
          this.Property(t => t.contacts).HasMaxLength(50);
          this.Property(t => t.cPhone).HasMaxLength(50);
          this.Property(t => t.Cstate);
          this.Property(t => t.sales);
          this.Property(t => t.prosceniumIss);
          this.Property(t => t.Ishire);
          this.Property(t => t.area).HasMaxLength(50);
          this.Property(t => t.City).HasMaxLength(20);
          this.Property(t => t.Contsrr).HasMaxLength(20);
          this.Property(t => t.Shiji).HasMaxLength(20);
          this.Property(t => t.Email).HasMaxLength(50);
          this.Property(t => t.ybNum).HasMaxLength(20);
          this.Property(t => t.Address).HasMaxLength(50);
          this.Property(t => t.companyPhone).HasMaxLength(50);
          this.Property(t => t.Fax).HasMaxLength(50);
          this.Property(t => t.homepage).HasMaxLength(50);
          this.Property(t => t.Csource);
          this.Property(t => t.cindustry);
          this.Property(t => t.Ischalk);
          this.Property(t => t.limit);
          this.Property(t => t.Remark).HasMaxLength(100);
          this.Property(t => t.AddDate);
          this.Property(t => t.editUser).HasMaxLength(50);
          this.Property(t => t.verifyUser);
          this.Property(t => t.isVerify);
          this.Property(t => t.Hotel).HasMaxLength(50);
          this.Property(t => t.Details).HasMaxLength(500);
          this.Property(t => t.occNum);
          this.Property(t => t.NoShow);
          this.Property(t => t.xqBook);
          this.Property(t => t.Pming);
          this.Property(t => t.isXz);
          this.Property(t => t.createtime);
          this.Property(t => t.updatetime);
       }
    }
}
