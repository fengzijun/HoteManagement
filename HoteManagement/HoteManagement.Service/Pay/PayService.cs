using Autofac.Extras.DynamicProxy;
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
using AutoMapper;

namespace HoteManagement.Service.Pay
{
    [Intercept(typeof(UnitOfWorkInterceptor))]
    public class PayService:ApplicationService,IPayService
    {
        public PayService(IRepository<Domain.account_goods> account_goodsRepository,
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

        public void AddGoodsAccount(goods_accountDto goodaccount)
        {
            Domain.goods_account model = AutoMapper.Mapper.Map<Domain.goods_account>(goodaccount);
            _goods_accountRepository.Insert(model);
        }

        public List<meth_payDto> GetMethPayList(bool? methisya, bool? meth_is_jie)
        {
            var result = _meth_payRepository.TableNoTracking;

            if (methisya.HasValue)
                result = result.Where(s => s.meth_is_ya == methisya);
            if (meth_is_jie.HasValue)
                result = result.Where(s => s.meth_is_jie == meth_is_jie);

            return result.ProjectToList<meth_payDto>();
        }

        public void Addmeth_pay(meth_payDto meth_Pay)
        {
            Domain.meth_pay model = AutoMapper.Mapper.Map<Domain.meth_pay>(meth_Pay);
            _meth_payRepository.Insert(model);

        }

        public void Updatemeth_pay(meth_payDto meth_Pay)
        {
            Domain.meth_pay model = AutoMapper.Mapper.Map<Domain.meth_pay>(meth_Pay);
            _meth_payRepository.Update(model);

        }

        public meth_payDto Getmeth_payId(int id)
        {
            return _meth_payRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<meth_payDto>();
        }

  

        public void Deletemeth_pay(int id)
        {
            _meth_payRepository.Delete(id);
        }


    }
}
