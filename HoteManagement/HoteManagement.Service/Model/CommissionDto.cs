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
    
    
    public class CommissionDto : BaseDtoEntity
    {
        
        public string Accounts { get; set; }
        public string CommDesp { get; set; }
        public Nullable<System.DateTime> CommDate { get; set; }
        public Nullable<int> CommSum { get; set; }
        public Nullable<bool> IsBack { get; set; }
        public string GoodNumber { get; set; }
        public Nullable<bool> IsEveryDay { get; set; }
        public Nullable<int> DayComm { get; set; }
        public string CommRemark { get; set; }
    }
}
