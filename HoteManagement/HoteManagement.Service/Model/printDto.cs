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
    
    public partial class printDto : BaseDtoEntity
    {
        
        public Nullable<int> hotelid { get; set; }
        public string pritName { get; set; }
        public string priContent { get; set; }
    		public virtual HotelDto UserHotel { get; set; }
    		}
}
