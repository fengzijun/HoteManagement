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
    }
}
