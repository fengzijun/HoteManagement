using Autofac.Extras.DynamicProxy;
using AutoMapper;
using HoteManagement.Caching;
using HoteManagement.Data;
using HoteManagement.Infrastructure.UnitOfWork;
using HoteManagement.Service.Events;
using HoteManagement.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteManagement.Service.User
{
    [Intercept(typeof(UnitOfWorkInterceptor))]
    public class UserService : ApplicationService, IUserService
    {
        public UserService(IRepository<Domain.account_goods> account_goodsRepository,
                IRepository<Domain.Accounts_Roles> accounts_rolesRepository,
                IRepository<Domain.Accounts_UserRoles> accounts_userrolesRepository,
                IRepository<Domain.Accounts_Users> accounts_usersRepository,
                IRepository<Domain.AddPrice> addpriceRepository,
                IRepository<Domain.apartment> apartmentRepository,
                IRepository<Domain.banner> bannerRepository,
                IRepository<Domain.Book_Rdetail> book_rdetailRepository,
                IRepository<Domain.book_room> book_roomRepository,
                IRepository<Domain.BookState> bookstateRepository,
                IRepository<Domain.card_type> card_typeRepository,
                IRepository<Domain.cCall> ccallRepository,
                IRepository<Domain.cDepartment> cdepartmentRepository,
                IRepository<Domain.cIndustry> cindustryRepository,
                IRepository<Domain.comm_unit> comm_unitRepository,
                IRepository<Domain.Commission> commissionRepository,
                IRepository<Domain.Contacts> contactsRepository,
                IRepository<Domain.cost_type> cost_typeRepository,
                IRepository<Domain.cPost> cpostRepository,
                IRepository<Domain.cprotocol> cprotocolRepository,
                IRepository<Domain.cprotocolPrice> cprotocolpriceRepository,
                IRepository<Domain.cpType> cptypeRepository,
                IRepository<Domain.csysType> csystypeRepository,
                IRepository<Domain.customer> customerRepository,
                IRepository<Domain.customerState> customerstateRepository,
                IRepository<Domain.customerType> customertypeRepository,
                IRepository<Domain.Entry> entryRepository,
                IRepository<Domain.ExceedScheme> exceedschemeRepository,
                IRepository<Domain.floor_ld> floor_ldRepository,
                IRepository<Domain.floor_manage> floor_manageRepository,
                IRepository<Domain.FtSet> ftsetRepository,
                IRepository<Domain.Goods> goodsRepository,
                IRepository<Domain.goods_account> goods_accountRepository,
                IRepository<Domain.guest_source> guest_sourceRepository,
                IRepository<Domain.hour_room> hour_roomRepository,
                IRepository<Domain.hourse_scheme> hourse_schemeRepository,
                IRepository<Domain.info> infoRepository,
                IRepository<Domain.member> memberRepository,
                IRepository<Domain.memberState> memberstateRepository,
                IRepository<Domain.memberType> membertypeRepository,
                IRepository<Domain.Menu> menuRepository,
                IRepository<Domain.meth_pay> meth_payRepository,
                IRepository<Domain.modes> modesRepository,
                IRepository<Domain.mRecords> mrecordsRepository,
                IRepository<Domain.mtPrice> mtpriceRepository,
                IRepository<Domain.occu_infor> occu_inforRepository,
                IRepository<Domain.occu_informx> occu_informxRepository,
                IRepository<Domain.order_infor> order_inforRepository,
                IRepository<Domain.paymentMoney> paymentmoneyRepository,
                IRepository<Domain.price_type> price_typeRepository,
                IRepository<Domain.print> printRepository,
                IRepository<Domain.real_mode> real_modeRepository,
                IRepository<Domain.real_state> real_stateRepository,
                IRepository<Domain.Remaker> remakerRepository,
                IRepository<Domain.Repair> repairRepository,
                IRepository<Domain.RoleMenu> rolemenuRepository,
                IRepository<Domain.room_feature> room_featureRepository,
                IRepository<Domain.room_number> room_numberRepository,
                IRepository<Domain.room_state> room_stateRepository,
                IRepository<Domain.room_type> room_typeRepository,
                IRepository<Domain.room_type_image> room_type_imageRepository,
                IRepository<Domain.sale_man> sale_manRepository,
                IRepository<Domain.Shift> shiftRepository,
                IRepository<Domain.Shift_Exc> shift_excRepository,
                IRepository<Domain.shopInfo> shopinfoRepository,
                IRepository<Domain.Sincethehous> sincethehousRepository,
                IRepository<Domain.SuoRoom> suoroomRepository,
                IRepository<Domain.SuoSys> suosysRepository,
                IRepository<Domain.SysParamter> sysparamterRepository,
                IRepository<Domain.TypeScheme> typeschemeRepository,
                IRepository<Domain.UserInfo> userinfoRepository,
                IRepository<Domain.Users> usersRepository,
                IRepository<Domain.userType> usertypeRepository,
                IRepository<Domain.ZD_hourse> zd_hourseRepository,
                IDbContext dbcontext,
                IRedis redishelper,
                IEventPublisher eventPublisher,
                ILogger logger) : base(
                    account_goodsRepository,
                    accounts_rolesRepository,
               accounts_userrolesRepository,
                accounts_usersRepository,
               addpriceRepository,
                 apartmentRepository,
                bannerRepository,
                 book_rdetailRepository,
               book_roomRepository,
               bookstateRepository,
               card_typeRepository,
               ccallRepository,
             cdepartmentRepository,
             cindustryRepository,
             comm_unitRepository,
                commissionRepository,
               contactsRepository,
                 cost_typeRepository,
              cpostRepository,
              cprotocolRepository,
                cprotocolpriceRepository,
                 cptypeRepository,
               csystypeRepository,
              customerRepository,
                customerstateRepository,
               customertypeRepository,
              entryRepository,
                exceedschemeRepository,
               floor_ldRepository,
                 floor_manageRepository,
                ftsetRepository,
               goodsRepository,
                goods_accountRepository,
                 guest_sourceRepository,
               hour_roomRepository,
                hourse_schemeRepository,
                infoRepository,
                 memberRepository,
                memberstateRepository,
                membertypeRepository,
             menuRepository,
               meth_payRepository,
               modesRepository,
                 mrecordsRepository,
                mtpriceRepository,
                occu_inforRepository,
                occu_informxRepository,
                order_inforRepository,
                paymentmoneyRepository,
                 price_typeRepository,
                 printRepository,
                 real_modeRepository,
                real_stateRepository,
                 remakerRepository,
                 repairRepository,
                rolemenuRepository,
                room_featureRepository,
                 room_numberRepository,
                room_stateRepository,
                room_typeRepository,
                 room_type_imageRepository,
                sale_manRepository,
                 shiftRepository,
                 shift_excRepository,
                 shopinfoRepository,
                sincethehousRepository,
                suoroomRepository,
                suosysRepository,
                sysparamterRepository,
               typeschemeRepository,
                userinfoRepository,
                usersRepository,
               usertypeRepository,
                zd_hourseRepository,
                 dbcontext,
                 redishelper,
                 eventPublisher,
                 logger)
        {
        }


        public virtual bool CheckAccountUser(string username , string pwd)
        {
            return _accounts_usersRepository.TableNoTracking.Where(s => s.UserName == username && s.Password == pwd).FirstOrDefault() != null;
        }

        public virtual void UpdateAccountUser(Accounts_UsersDto user)
        {
            Domain.Accounts_Users accounts_Users = AutoMapper.Mapper.Map<Domain.Accounts_Users>(user);
            _accounts_usersRepository.Update(accounts_Users);
        }

        public virtual Accounts_UsersDto GetAccountUser(string username,string pwd)
        {
            return _accounts_usersRepository.TableNoTracking.Where(s => s.UserName == username && s.Password == pwd).ProjectToFirstOrDefault<Accounts_UsersDto>();
        }

        public virtual Accounts_UsersDto GetAccountUser(string username)
        {
            return _accounts_usersRepository.TableNoTracking.Where(s => s.UserName == username).ProjectToFirstOrDefault<Accounts_UsersDto>();
        }

        public virtual Accounts_UsersDto GetAccountUser(int id)
        {
            return _accounts_usersRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<Accounts_UsersDto>();
        }

        public virtual UserMenus GetAccountMenus(int userid)
        {
            var accoutrole = _accounts_rolesRepository.TableNoTracking.Where(s => s.Id == userid).FirstOrDefault();
            var rolemenus = _rolemenuRepository.TableNoTracking.Where(s => s.RoleID == accoutrole.RoleID).ToList();

            var parnetids = rolemenus.Select(s => s.Menu_pid).Distinct().ToArray();

            var parentmenus = _menuRepository.TableNoTracking.Where(s => parnetids.Contains(s.Id)).ProjectToList<MenuDto>();

            UserMenus userMenus = new UserMenus { RoleId = accoutrole.RoleID, UserId = userid };
            List<Menu> menus = new List<Menu>();
         
            foreach (var item in parentmenus)
            {
                var menu = new Menu { ParentMenu = item };
                var childrenmenus = _rolemenuRepository.TableNoTracking.Where(s => s.RoleID == accoutrole.RoleID && s.Menu_pid == item.Id).ToList();
                foreach(var chlilditem in childrenmenus)
                {
                    var clildmenu = _menuRepository.TableNoTracking.Where(s => s.Id == chlilditem.Menu_id).ProjectToFirst<MenuDto>();
                    if(clildmenu!=null)
                    {
                        menu.ClildMenus.Add(clildmenu);
                    }
                }
                menus.Add(menu);
                
            }
            userMenus.Menus = menus;
            return userMenus;
        }


        public customerDto GetCustomer(string account)
        {
            return _customerRepository.TableNoTracking.Where(s => s.accounts == account).ProjectToFirstOrDefault<customerDto>();
        }

        public customerDto GetCustomerById(int id)
        {
            return _customerRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<customerDto>();
        }

        public void UpdateCustomer(customerDto customer)
        {
            Domain.customer model = AutoMapper.Mapper.Map<Domain.customer>(customer);
            _customerRepository.Update(model);
        }

        public List<CommissionDto> GetCommission(string account)
        {
            var result = _commissionRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(account))
                result = result.Where(s => s.Accounts == account);

            return result.ProjectToList<CommissionDto>();
        }

        public CommissionDto GetCommissionById(int id)
        {
            return _commissionRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirst<CommissionDto>();
        }

        public List<CommissionDto> GetCommissionByIds(int[] ids)
        {
            return _commissionRepository.TableNoTracking.Where(s => ids.Contains( s.Id)).ProjectToList<CommissionDto>();
        }

        public void Addcprotocol(cprotocolDto cprotocol)
        {
            Domain.cprotocol model = AutoMapper.Mapper.Map<Domain.cprotocol>(cprotocol);
            _cprotocolRepository.Insert(model);
        }

        public void Updatecprotocol(cprotocolDto cprotocol)
        {
            Domain.cprotocol model = AutoMapper.Mapper.Map<Domain.cprotocol>(cprotocol);
            _cprotocolRepository.Update(model);
        }

        public cprotocolDto GetcprotocolById(int id)
        {
            return _cprotocolRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<cprotocolDto>();
        }

        public List<cprotocolDto> Getcprotocol(string account)
        {
            return _cprotocolRepository.TableNoTracking.Where(s => s.Accounts == account).ProjectToList<cprotocolDto>();
        }

        public List<cprotocolPriceDto> GetcprotocolPrice(string accounts , int? cpid)
        {
            var result = _cprotocolpriceRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(accounts))
                result = result.Where(s => s.Accounts == accounts);
            if (cpid.HasValue)
                result = result.Where(s => s.cpID == cpid.Value);

            return result.ProjectToList<cprotocolPriceDto>();

        }

        public void AddcprotocolPrice(cprotocolPriceDto cprotocolPrice)
        {
            Domain.cprotocolPrice model = AutoMapper.Mapper.Map<Domain.cprotocolPrice>(cprotocolPrice);
            _cprotocolpriceRepository.Insert(model);
        }

        public void UpdatecprotocolPrice(cprotocolPriceDto cprotocolPrice)
        {
            Domain.cprotocolPrice model = AutoMapper.Mapper.Map<Domain.cprotocolPrice>(cprotocolPrice);
            _cprotocolpriceRepository.Update(model);
        }

        public virtual List<ContactsDto> GetContacts(string account)
        {
            var result = _contactsRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(account))
                result = result.Where(s => s.Accounts == account);

            return result.ProjectToList<ContactsDto>();

        }

        public void AddMember(memberDto member)
        {
            Domain.member model = AutoMapper.Mapper.Map<Domain.member>(member);
            _memberRepository.Insert(model);
        }

        public void UpdateMember(memberDto member)
        {
            Domain.member model = AutoMapper.Mapper.Map<Domain.member>(member);
            _memberRepository.Update(model);
        }


        public virtual memberDto GetMember(int id)
        {
            return _memberRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<memberDto>();
        }

        public virtual memberStateDto GetMemberState(int id)
        {
            return _memberstateRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<memberStateDto>();
        }

        public virtual List<memberTypeDto> GetmembertypeList(string name,int? stateid,int? mtype,DateTime? startime ,DateTime? endtime)
        {
            var result = _memberRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(name))
                result = result.Where(s => s.Name.StartsWith(name));
            if(stateid.HasValue)
                result = result.Where(s => s.Statid == stateid);

            if (mtype.HasValue)
                result = result.Where(s => s.Mtype == mtype);

            if(startime.HasValue)
                result = result.Where(s => s.Baithday > startime);

            if (endtime.HasValue)
                result = result.Where(s => s.Baithday < endtime);

            return result.ProjectToList<memberTypeDto>();
        }


        public virtual memberTypeDto Getmembertype(int id)
        {
            return _membertypeRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirstOrDefault<memberTypeDto>();
        }

        public virtual void AddMemberType(memberTypeDto memberType)
        {
            Domain.memberType model = AutoMapper.Mapper.Map<Domain.memberType>(memberType);
            _membertypeRepository.Insert(model);
        }

        public virtual void UpdateMemberType(memberTypeDto memberType)
        {
            Domain.memberType model = AutoMapper.Mapper.Map<Domain.memberType>(memberType);
            _membertypeRepository.Update(model);
        }

        public virtual List<UsersDto> GetUserList(string userid,int? id,int? usertype)
        {
            var result = _usersRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(userid))
                result = result.Where(s => s.userid == userid);
            if (usertype.HasValue)
                result = result.Where(s => s.user_type == usertype);
            if (id.HasValue)
                result = result.Where(s => s.Id == id.Value);

            return result.ProjectToList<UsersDto>();
        }


        public virtual List<userTypeDto> GetUserTypeList(int? typeid)
        {
            var result = _usertypeRepository.TableNoTracking;
            if (typeid.HasValue)
                result = result.Where(s => s.typeid == typeid);

            return result.ProjectToList<userTypeDto>();
        }

        public virtual userTypeDto GetUserType(int id)
        {

            return _usertypeRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirstOrDefault<userTypeDto>();
        }

        public virtual void AddUserType(userTypeDto userType)
        {
            Domain.userType model = AutoMapper.Mapper.Map<Domain.userType>(userType);
            _usertypeRepository.Insert(model);
        }

        public virtual void UpdateUserType(userTypeDto userType)
        {
            Domain.userType model = AutoMapper.Mapper.Map<Domain.userType>(userType);
            _usertypeRepository.Update(model);
        }

        public virtual List<mtPriceDto> GetMtPrice(int mtid)
        {
            return _mtpriceRepository.TableNoTracking.Where(s => s.MTID == mtid).ProjectToList<mtPriceDto>();
        }
    }
}
