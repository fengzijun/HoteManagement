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
    
    public partial class Goods : BaseEntity
    {
        
        public Nullable<int> hotelid { get; set; }
        public string Goods_number { get; set; }
        public string Goods_name { get; set; }
        public Nullable<decimal> Goods_price { get; set; }
        public string Goods_unit { get; set; }
        public string Goods_state { get; set; }
        public string Goods_spell { get; set; }
        public Nullable<int> Goods_ifType { get; set; }
        public Nullable<int> Goods_categories { get; set; }
        public string Goods_Remaker { get; set; }
        public Nullable<int> Goods_jf { get; set; }
    		public virtual Hotel UserHotel { get; set; }
    		}
}
