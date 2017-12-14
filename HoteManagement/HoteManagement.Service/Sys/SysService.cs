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

namespace HoteManagement.Service.Sys
{
    [Intercept(typeof(UnitOfWorkInterceptor))]
    public class SysService : ApplicationService, ISysService
    {
        public SysService(IRepository<Domain.account_goods> account_goodsRepository,
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



        public virtual int GetBannerCount()
        {
            int count = _bannerRepository.TableNoTracking.Count();
            if (count == 0)
                return 1;
            else
                return count + 1;
        }

        public virtual void AddBanner(bannerDto bannerDto)
        {
            Domain.banner banner = AutoMapper.Mapper.Map<Domain.banner>(bannerDto);
            banner.banner_id = Guid.NewGuid().ToString();

            _bannerRepository.Insert(banner);

        }

        public virtual IPagedList<bannerDto> GetBannerPageList(int pageindex,int pagesize)
        {
            var resultquery = _bannerRepository.TableNoTracking.OrderByDescending(s => s.sortId);

            var list = new PagedList<bannerDto>(resultquery.ProjectToQueryable<bannerDto>(), pageindex, pagesize);

            return list;
        }

        public virtual bannerDto GetBannerByBannerId(string id)
        {
            return _bannerRepository.TableNoTracking.Where(s => s.banner_id == id).ProjectToFirst<bannerDto>();
        }

        public virtual void UpdateBanner(bannerDto banner)
        {
            Domain.banner model = AutoMapper.Mapper.Map<Domain.banner>(banner);
            _bannerRepository.Update(model);
        }

        public virtual SysParamterDto GetSysParamterById(int id)
        {
            return _sysparamterRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<SysParamterDto>();
        }

        public virtual List<cCallDto> GetCCallList()
        {
            return _ccallRepository.TableNoTracking.ProjectToList<cCallDto>();
        }

        public virtual cCallDto GetCCall(int id)
        {
            return _ccallRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirst<cCallDto>();
        }


        public virtual List<cpTypeDto> GetcptypeList()
        {
            return _cptypeRepository.TableNoTracking.ProjectToList<cpTypeDto>();
        }

        public virtual cpTypeDto Getcptype(int id)
        {
            return _cptypeRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirst<cpTypeDto>();
        }


        public virtual List<cDepartmentDto> GetcDepartmentList()
        {
            return _cdepartmentRepository.TableNoTracking.ProjectToList<cDepartmentDto>();
        }

        public virtual cDepartmentDto GetcDepartment(int id)
        {
            return _cdepartmentRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirst<cDepartmentDto>();
        }


        public virtual List<cPostDto> GetcPostList()
        {
            return _cpostRepository.TableNoTracking.ProjectToList<cPostDto>();
        }

        public virtual cPostDto GetcPost(int id)
        {
            return _cdepartmentRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirst<cPostDto>();
        }

        public virtual List<csysTypeDto> GetcsysTypeList()
        {
            return _csystypeRepository.TableNoTracking.ProjectToList<csysTypeDto>();
        }

        public virtual List<customerTypeDto> GetcustomerTypeList()
        {
            return _customertypeRepository.TableNoTracking.ProjectToList<customerTypeDto>();
        }

        public virtual List<customerStateDto> GetcustomerStateList()
        {
            return _customerstateRepository.TableNoTracking.ProjectToList<customerStateDto>();
        }

        public virtual customerStateDto GetcustomerState(int id)
        {
            return _customerstateRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirst<customerStateDto>();
        }



        public virtual List<cIndustryDto> GetcIndustryList()
        {
            return _cindustryRepository.TableNoTracking.ProjectToList<cIndustryDto>();
        }

        public virtual cIndustryDto GetcIndustry(int id)
        {
            return _cindustryRepository.TableNoTracking.Where(s=>s.Id == id).ProjectToFirst<cIndustryDto>();
        }

        public virtual List<cost_typeDto> GetCostType(int? ct_iftype,int? ct_categories)
        {
            var result = _cost_typeRepository.TableNoTracking;
            if (ct_iftype.HasValue)
                result = result.Where(s => s.ct_iftype == ct_iftype);

            if (ct_categories.HasValue)
                result = result.Where(s => s.ct_categories == ct_categories);

            return result.ProjectToList<cost_typeDto>();
        }


        public virtual GoodsDto GetGoods(int id)
        {
            return _goodsRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirst<GoodsDto>();

        }



        public virtual List<AddPriceDto> GetAddPriceList()
        {
            return _addpriceRepository.TableNoTracking.ProjectToList<AddPriceDto>();
        }


        public virtual void AddmRecords(mRecordsDto mRecords)
        {
            Domain.mRecords records = AutoMapper.Mapper.Map<Domain.mRecords>(mRecords);
            _mrecordsRepository.Insert(records);
        }

        public virtual List<mRecordsDto> GetmRecords(string mid)
        {

            var result = _mrecordsRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(mid))
                result = result.Where(s => s.mmid == mid);
   
            return result.ProjectToList<mRecordsDto>();

        }


        public virtual List<mRecordsDto> GetmRecordsByType(string mid)
        {

            var result = _mrecordsRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(mid))
                result = result.Where(s => s.mmid == mid);
            result = result.Where(s => s.Type == 3 || s.Type == 4);

            return result.ProjectToList<mRecordsDto>();

        }

        public virtual List<mRecordsDto> GetmRecordsByType2(string mid)
        {

            var result = _mrecordsRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(mid))
                result = result.Where(s => s.mmid == mid);
            result = result.Where(s => s.Type == 1 || s.Type == 2);

            return result.ProjectToList<mRecordsDto>();

        }
    }
}
