using HoteManagement.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteManagement.Service.Pay
{
    public interface IPayService
    {

        void AddGoodsAccount(goods_accountDto goodaccount);

        List<meth_payDto> GetMethPayList(bool? methisya, bool? meth_is_jie);
      
    }
}
