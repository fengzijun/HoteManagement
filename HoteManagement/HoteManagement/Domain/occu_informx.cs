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
    
    public partial class occu_informx : BaseEntity
    {
        
        public Nullable<int> hotelid { get; set; }
        public string occ_no { get; set; }
        public Nullable<int> order_id { get; set; }
        public string occ_name { get; set; }
        public string occ_with { get; set; }
        public Nullable<int> real_type_id { get; set; }
        public string room_number { get; set; }
        public Nullable<int> real_scheme_id { get; set; }
        public Nullable<int> source_id { get; set; }
        public string mem_cardno { get; set; }
        public Nullable<int> real_mode_id { get; set; }
        public Nullable<decimal> real_price { get; set; }
        public Nullable<System.DateTime> occ_time { get; set; }
        public Nullable<int> stay_day { get; set; }
        public Nullable<decimal> stay_deposit { get; set; }
        public Nullable<System.DateTime> depar_time { get; set; }
        public Nullable<System.DateTime> pha_sched { get; set; }
        public Nullable<int> card_id { get; set; }
        public string card_no { get; set; }
        public string brithday { get; set; }
        public string sex { get; set; }
        public string family_name { get; set; }
        public string address { get; set; }
        public Nullable<int> state_id { get; set; }
        public Nullable<decimal> deposit { get; set; }
        public Nullable<decimal> amount_money { get; set; }
        public string sort { get; set; }
        public string lordRoomid { get; set; }
        public Nullable<int> continuelive { get; set; }
        public string phonenum { get; set; }
    		public virtual Hotel UserHotel { get; set; }
    		}
}
