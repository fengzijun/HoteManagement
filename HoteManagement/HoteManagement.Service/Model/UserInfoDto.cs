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
    
    public partial class UserInfoDto : BaseDtoEntity
    {
        
        public Nullable<int> hotelid { get; set; }
        public string userID { get; set; }
        public string cardID { get; set; }
        public Nullable<bool> sex { get; set; }
        public Nullable<int> cardTypeID { get; set; }
        public string cardValue { get; set; }
        public Nullable<int> typeid { get; set; }
        public string xiaoshou { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> bairthday { get; set; }
        public string xihao { get; set; }
        public string address { get; set; }
        public string meark { get; set; }
        public Nullable<int> manageID { get; set; }
        public string truename { get; set; }
    		public virtual HotelDto UserHotel { get; set; }
    		}
}
