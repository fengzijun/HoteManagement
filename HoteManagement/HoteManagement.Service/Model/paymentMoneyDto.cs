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
    
    
    public class paymentMoneyDto : BaseDtoEntity
    {
        
        public Nullable<decimal> pm_Money { get; set; }
        public Nullable<int> pm_MethPayid { get; set; }
        public string pm_Name { get; set; }
        public string pm_roomNumber { get; set; }
        public Nullable<System.DateTime> pm_Date { get; set; }
        public string pm_Remaker { get; set; }
    }
}