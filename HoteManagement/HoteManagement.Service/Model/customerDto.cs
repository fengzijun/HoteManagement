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
    
    public partial class customerDto : BaseDtoEntity
    {
        
        public Nullable<int> hotelid { get; set; }
        public string accounts { get; set; }
        public string cName { get; set; }
        public Nullable<int> sysType { get; set; }
        public Nullable<int> cusType { get; set; }
        public string cusDesy { get; set; }
        public string cusNumber { get; set; }
        public string contacts { get; set; }
        public string cPhone { get; set; }
        public Nullable<int> Cstate { get; set; }
        public Nullable<int> sales { get; set; }
        public Nullable<bool> prosceniumIss { get; set; }
        public Nullable<bool> Ishire { get; set; }
        public string area { get; set; }
        public string City { get; set; }
        public string Contsrr { get; set; }
        public string Shiji { get; set; }
        public string Email { get; set; }
        public string ybNum { get; set; }
        public string Address { get; set; }
        public string companyPhone { get; set; }
        public string Fax { get; set; }
        public string homepage { get; set; }
        public Nullable<int> Csource { get; set; }
        public Nullable<int> cindustry { get; set; }
        public Nullable<bool> Ischalk { get; set; }
        public Nullable<int> limit { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public string editUser { get; set; }
        public Nullable<int> verifyUser { get; set; }
        public Nullable<bool> isVerify { get; set; }
        public string Hotel { get; set; }
        public string Details { get; set; }
        public Nullable<int> occNum { get; set; }
        public Nullable<int> NoShow { get; set; }
        public Nullable<int> xqBook { get; set; }
        public Nullable<int> Pming { get; set; }
        public Nullable<bool> isXz { get; set; }
    		public virtual HotelDto UserHotel { get; set; }
    		}
}
