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

namespace HoteManagement.Domain
{
    
    public partial class Menu : BaseEntity
    {
        
        public string title { get; set; }
        public Nullable<int> parent_id { get; set; }
        public string url { get; set; }
        public string imgurl { get; set; }
        public Nullable<int> sortId { get; set; }
        public Nullable<bool> isable { get; set; }
    }
}
