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
    
    
    public class SysParamterDto : BaseDtoEntity
    {
        
        public Nullable<int> CancellMin { get; set; }
        public Nullable<bool> IsDeposit { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<bool> IsEarlyRoom { get; set; }
        public Nullable<System.TimeSpan> EarlyStart { get; set; }
        public Nullable<System.TimeSpan> EarlyEnd { get; set; }
        public Nullable<System.TimeSpan> EarlyOutTime { get; set; }
        public Nullable<int> EarlyFee { get; set; }
        public Nullable<int> EarlyFeeSel { get; set; }
        public Nullable<System.TimeSpan> EarlyOutTimes { get; set; }
        public Nullable<int> EarlyFeeTwo { get; set; }
        public Nullable<System.TimeSpan> DayOutTime { get; set; }
        public Nullable<int> DayFee { get; set; }
        public Nullable<System.TimeSpan> DayFeeTwo { get; set; }
        public Nullable<System.TimeSpan> DayTime { get; set; }
        public Nullable<bool> istype { get; set; }
        public Nullable<System.TimeSpan> ysTime { get; set; }
        public Nullable<bool> isOcczf { get; set; }
        public Nullable<bool> isCy { get; set; }
        public string MarkSuo { get; set; }
    }
}
