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
    
    
    public class Book_RdetailMap : BaseEntityTypeConfiguration<HoteManagement.Domain.Book_Rdetail>
    {
       public Book_RdetailMap()
       {
          this.HasKey(t => t.Id);
          this.Property(t => t.Book_no).HasMaxLength(20);
          this.Property(t => t.Real_type_Id);
          this.Property(t => t.Room_number).HasMaxLength(20);
          this.Property(t => t.Real_num);
          this.Property(t => t.Book_Price);
          this.Property(t => t.Real_Price);
          this.Property(t => t.Real_Scheme_Id);
          this.Property(t => t.Ok_num);
          this.Property(t => t.Room_typeid);
       }
    }
}
