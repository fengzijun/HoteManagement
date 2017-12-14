using HoteManagement.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteManagement.Service.User
{
    public interface IUserService
    {

        bool CheckAccountUser(string username, string pwd);


        Accounts_UsersDto GetAccountUser(string username);


        Accounts_UsersDto GetAccountUser(int id);

        Accounts_UsersDto GetAccountUser(string username, string pwd);

        void UpdateAccountUser(Accounts_UsersDto user);

        UserMenus GetAccountMenus(int userid);

        customerDto GetCustomer(string account);
      

        customerDto GetCustomerById(int id);
      

        void UpdateCustomer(customerDto customer);


        List<CommissionDto> GetCommission(string account);


        CommissionDto GetCommissionById(int id);


        List<CommissionDto> GetCommissionByIds(int[] ids);


        void Addcprotocol(cprotocolDto cprotocol);


        void Updatecprotocol(cprotocolDto cprotocol);


        cprotocolDto GetcprotocolById(int id);


        List<cprotocolDto> Getcprotocol(string account);


        List<cprotocolPriceDto> GetcprotocolPrice(string accounts, int? cpid);


        void AddcprotocolPrice(cprotocolPriceDto cprotocolPrice);


        void UpdatecprotocolPrice(cprotocolPriceDto cprotocolPrice);

        List<ContactsDto> GetContacts(string account);
      
    }
}
