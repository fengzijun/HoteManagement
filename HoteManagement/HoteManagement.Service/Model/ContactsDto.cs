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

namespace HoteManagement.Service.Model
{
    
    
    public class ContactsDto : BaseDtoEntity
    {
        
        public string Accounts { get; set; }
        public string cName { get; set; }
        public Nullable<bool> Sex { get; set; }
        public Nullable<System.DateTime> Bearthday { get; set; }
        public string editUser { get; set; }
        public Nullable<System.DateTime> addDatetime { get; set; }
        public Nullable<int> Appellation { get; set; }
        public Nullable<int> department { get; set; }
        public string officPhone { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string zipcode { get; set; }
        public string Mail { get; set; }
        public string familyPhone { get; set; }
        public string Likes { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Post { get; set; }
    }
}
