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

        public virtual void UpdateSysParamter(SysParamterDto sysParamter)
        {
            Domain.SysParamter model = AutoMapper.Mapper.Map<Domain.SysParamter>(sysParamter);
            _sysparamterRepository.Update(model);
        }

        public virtual void AddSysParamter(SysParamterDto sysParamter)
        {
            Domain.SysParamter model = AutoMapper.Mapper.Map<Domain.SysParamter>(sysParamter);
            _sysparamterRepository.Insert(model);
        }

        public virtual void AddExceedScheme(ExceedSchemeDto exceedScheme)
        {
            Domain.ExceedScheme model = AutoMapper.Mapper.Map<Domain.ExceedScheme>(exceedScheme);
            _exceedschemeRepository.Insert(model);
        }

        public virtual void UpdateExceedScheme(ExceedSchemeDto exceedScheme)
        {
            Domain.ExceedScheme model = AutoMapper.Mapper.Map<Domain.ExceedScheme>(exceedScheme);
            _exceedschemeRepository.Update(model);
        }

        public virtual ExceedSchemeDto GetExceedSchemeById(int id)
        {
            return _exceedschemeRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<ExceedSchemeDto>();
        }

        public virtual List<ExceedSchemeDto> GetExceedSchemeList(int? typeroom)
        {
            var result = _exceedschemeRepository.TableNoTracking;
            if (typeroom.HasValue)
                result = result.Where(s => s.TypeRoom == typeroom.Value);

            return result.ProjectToList<ExceedSchemeDto>();
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

        public void Addfloor_manage(floor_manageDto floor_Manage)
        {
            Domain.floor_manage mdoel = AutoMapper.Mapper.Map<Domain.floor_manage>(floor_Manage);
       

            _floor_manageRepository.Insert(mdoel);

        }

        public void Updatefloor_manage(floor_manageDto floor_Manage)
        {
            Domain.floor_manage mdoel = AutoMapper.Mapper.Map<Domain.floor_manage>(floor_Manage);


            _floor_manageRepository.Update(mdoel);

        }

        public List<floor_manageDto> Getfloor_manageList()
        {
            return _floor_manageRepository.TableNoTracking.ProjectToList<floor_manageDto>();
        }

        public floor_manageDto GetFloor_ManageById(int id)
        {
            return _floor_manageRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<floor_manageDto>();
        }

        public void Updategoods(GoodsDto goods)
        {
            Domain.Goods model = AutoMapper.Mapper.Map<Domain.Goods>(goods);
            _goodsRepository.Update(model);

        }

        public void Addgoods(GoodsDto goods)
        {
            Domain.Goods model = AutoMapper.Mapper.Map<Domain.Goods>(goods);
            _goodsRepository.Insert(model);

        }

        public List<GoodsDto> GetGoodsList(int? Goods_ifType,int? Goods_categories)
        {
            var result = _goodsRepository.TableNoTracking;
            if (Goods_ifType.HasValue)
                result = result.Where(s => s.Goods_ifType == Goods_ifType);
            if (Goods_categories.HasValue)
                result = result.Where(s => s.Goods_categories == Goods_categories);

            return result.ProjectToList<GoodsDto>();
        }

        public IPagedList<GoodsDto> GetGoodsList(int? Goods_ifType, int? Goods_categories, int pageindex, int pagesize)
        {
            var result = _goodsRepository.TableNoTracking;
            if (Goods_ifType.HasValue)
                result = result.Where(s => s.Goods_ifType == Goods_ifType);
            if (Goods_categories.HasValue)
                result = result.Where(s => s.Goods_categories == Goods_categories);

            

            return new PagedList<GoodsDto>(result.ProjectToQueryable<GoodsDto>(), pageindex, pagesize);
        }

        public cost_typeDto GetCost_Type(int id)
        {
            return _cost_typeRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<cost_typeDto>();
        }

        public void UpdateCostType(cost_typeDto cost_Type)
        {
            Domain.cost_type model = AutoMapper.Mapper.Map<Domain.cost_type>(cost_Type);
            _cost_typeRepository.Update(model);
        }

        public void AddCostType(cost_typeDto cost_Type)
        {
            Domain.cost_type model = AutoMapper.Mapper.Map<Domain.cost_type>(cost_Type);
            _cost_typeRepository.Insert(model);
        }

        public void AddCustomerstate(customerDto customer)
        {
            Domain.customerState model = AutoMapper.Mapper.Map<Domain.customerState>(customer);
            _customerstateRepository.Insert(model);
        }

        public void UpdateCustomerstate(customerDto customer)
        {
            Domain.customerState model = AutoMapper.Mapper.Map<Domain.customerState>(customer);
            _customerstateRepository.Update(model);
        }

        public void AddcIndustry(cIndustryDto cIndustry)
        {
            Domain.cIndustry model = AutoMapper.Mapper.Map<Domain.cIndustry>(cIndustry);
            _cindustryRepository.Insert(model);
        }

        public void UpdatecIndustry(cIndustryDto customer)
        {
            Domain.cIndustry model = AutoMapper.Mapper.Map<Domain.cIndustry>(customer);
            _cindustryRepository.Update(model);
        }

        public void AddcpType(cpTypeDto cpType)
        {
            Domain.cpType model = AutoMapper.Mapper.Map<Domain.cpType>(cpType);
            _cptypeRepository.Insert(model);
        }

        public void UpdatecpType(cpTypeDto cpType)
        {
            Domain.cpType model = AutoMapper.Mapper.Map<Domain.cpType>(cpType);
            _cptypeRepository.Update(model);
        }

        public void AddcsysType(csysTypeDto csysType)
        {
            Domain.csysType model = AutoMapper.Mapper.Map<Domain.csysType>(csysType);
            _csystypeRepository.Insert(model);
        }

        public void UpdatecpType(csysTypeDto csysType)
        {
            Domain.csysType model = AutoMapper.Mapper.Map<Domain.csysType>(csysType);
            _csystypeRepository.Update(model);
        }

        public void AddcDepartment(cDepartmentDto cDepartment)
        {
            Domain.cDepartment model = AutoMapper.Mapper.Map<Domain.cDepartment>(cDepartment);
            _cdepartmentRepository.Insert(model);
        }

        public void UpdatecDepartment(cDepartmentDto cDepartment)
        {
            Domain.cDepartment model = AutoMapper.Mapper.Map<Domain.cDepartment>(cDepartment);
            _cdepartmentRepository.Update(model);
        }

        public void AddcPost(cPostDto cPost)
        {
            Domain.cPost model = AutoMapper.Mapper.Map<Domain.cPost>(cPost);
            _cpostRepository.Insert(model);
        }

        public void UpdatecPost(cPostDto cPost)
        {
            Domain.cPost model = AutoMapper.Mapper.Map<Domain.cPost>(cPost);
            _cpostRepository.Update(model);
        }

        public void AddcPost(cCallDto cCall)
        {
            Domain.cCall model = AutoMapper.Mapper.Map<Domain.cCall>(cCall);
            _ccallRepository.Insert(model);
        }

        public void UpdatecPost(cCallDto cCall)
        {
            Domain.cCall model = AutoMapper.Mapper.Map<Domain.cCall>(cCall);
            _ccallRepository.Update(model);
        }

        public void DeleteCustomerState(int id)
        {
            _customerstateRepository.Delete(id);
        }

        public void DeleteCustomType(int id)
        {
            _customertypeRepository.Delete(id);
        }

        public void DeletecIndustry(int id)
        {
            _cindustryRepository.Delete(id);
        }

        public void DeletecpType(int id)
        {
            _cptypeRepository.Delete(id);
        }

        public void DeletecsysType(int id)
        {
            _csystypeRepository.Delete(id);
        }

        public void DeletecDepartment(int id)
        {
            _cdepartmentRepository.Delete(id);
        }

        public void DeletecPost(int id)
        {
            _cpostRepository.Delete(id);
        }

        public void DeletecCall(int id)
        {
            _ccallRepository.Delete(id);
        }


        public virtual IPagedList<cost_typeDto> GetCostType(int? ct_iftype, int? ct_categories, string name,int pageindex ,int pagesize)
        {
            var result = _cost_typeRepository.TableNoTracking;
            if (ct_iftype.HasValue)
                result = result.Where(s => s.ct_iftype == ct_iftype);

            if (ct_categories.HasValue)
                result = result.Where(s => s.ct_categories == ct_categories);

            if (!string.IsNullOrEmpty(name))
                result = result.Where(s => s.ct_number.StartsWith(name) || s.ct_name.StartsWith(name));

            return new PagedList<cost_typeDto>(result.ProjectToQueryable<cost_typeDto>(), pageindex, pagesize);
        }


        public void AddShift(ShiftDto shift)
        {
            Domain.Shift model = AutoMapper.Mapper.Map<Domain.Shift>(shift);
            _shiftRepository.Insert(model);

        }

        public void UpdateShift(ShiftDto shift)
        {
            Domain.Shift model = AutoMapper.Mapper.Map<Domain.Shift>(shift);
            _shiftRepository.Update(model);

        }

        public ShiftDto GetShiftById(int id)
        {
            return _shiftRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<ShiftDto>();
        }

        public List<ShiftDto> GetShiftList()
        {
            return _shiftRepository.TableNoTracking.ProjectToList<ShiftDto>();
        }

        public void DeleteShift(int id)
        {
            _shiftRepository.Delete(id);
        }

        public void AddShiftInfo(shopInfoDto ShiftInfo)
        {
            Domain.shopInfo model = AutoMapper.Mapper.Map<Domain.shopInfo>(ShiftInfo);
            _shopinfoRepository.Insert(model);

        }

        public void UpdateShiftInfo(shopInfoDto ShiftInfo)
        {
            Domain.shopInfo model = AutoMapper.Mapper.Map<Domain.shopInfo>(ShiftInfo);
            _shopinfoRepository.Update(model);

        }

        public shopInfoDto GetShiftInfoById(int id)
        {
            return _shopinfoRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<shopInfoDto>();
        }

        public List<shopInfoDto> GetShiftInfoList()
        {
            return _shopinfoRepository.TableNoTracking.ProjectToList<shopInfoDto>();
        }

        public void DeleteShiftInfo(int id)
        {
            _shopinfoRepository.Delete(id);
        }

        public void Addfloor_id(floor_ldDto floor_id)
        {
            Domain.floor_ld model = AutoMapper.Mapper.Map<Domain.floor_ld>(floor_id);
            _floor_ldRepository.Insert(model);

        }

        public void Updatefloor_id(floor_ldDto floor_id)
        {
            Domain.floor_ld model = AutoMapper.Mapper.Map<Domain.floor_ld>(floor_id);
            _floor_ldRepository.Update(model);

        }

        public floor_ldDto Getfloor_idById(int id)
        {
            return _floor_ldRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<floor_ldDto>();
        }

        public List<floor_ldDto> Getfloor_idList()
        {
            return _floor_ldRepository.TableNoTracking.ProjectToList<floor_ldDto>();
        }

        public void Deletefloor_id(int id)
        {
            _floor_ldRepository.Delete(id);
        }


        public void Addprint(printDto print)
        {
            Domain.print model = AutoMapper.Mapper.Map<Domain.print>(print);
            _printRepository.Insert(model);

        }

        public void Updateprint(printDto print)
        {
            Domain.print model = AutoMapper.Mapper.Map<Domain.print>(print);
            _printRepository.Update(model);

        }

        public printDto GetprintById(int id)
        {
            return _printRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<printDto>();
        }

        public List<printDto> GetprintList()
        {
            return _printRepository.TableNoTracking.ProjectToList<printDto>();
        }

        public void Deleteprint(int id)
        {
            _printRepository.Delete(id);
        }

        public void AddSuoSys(SuoSysDto SuoSys)
        {
            Domain.SuoSys model = AutoMapper.Mapper.Map<Domain.SuoSys>(SuoSys);
            _suosysRepository.Insert(model);

        }

        public void UpdateSuoSys(SuoSysDto SuoSys)
        {
            Domain.SuoSys model = AutoMapper.Mapper.Map<Domain.SuoSys>(SuoSys);
            _suosysRepository.Update(model);

        }

        public SuoSysDto GetSuoSysById(int id)
        {
            return _suosysRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<SuoSysDto>();
        }

        public List<SuoSysDto> GetSuoSysList(string name)
        {
            var result = _suosysRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(name))
                result = result.Where(s => s.SuoTypeName == name);

            return result.ProjectToList<SuoSysDto>();
        }

        public void DeleteSuoSys(int id)
        {
            _suosysRepository.Delete(id);
        }

        public void AddSuoRoom(SuoRoomDto SuoRoom)
        {
            Domain.SuoRoom model = AutoMapper.Mapper.Map<Domain.SuoRoom>(SuoRoom);
            _suoroomRepository.Insert(model);

        }

        public void UpdateSuoRoom(SuoRoomDto SuoRoom)
        {
            Domain.SuoRoom model = AutoMapper.Mapper.Map<Domain.SuoRoom>(SuoRoom);
            _suoroomRepository.Update(model);

        }

        public SuoRoomDto GetSuoRoomById(int id)
        {
            return _suoroomRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<SuoRoomDto>();
        }

        public List<SuoRoomDto> GetSuoRoomList(string type,string roomnumber)
        {
            var result = _suoroomRepository.TableNoTracking;
            if (!string.IsNullOrEmpty(type))
                result = result.Where(s => s.SuoType == type);

            if (!string.IsNullOrEmpty(type))
                result = result.Where(s => s.RoomNumber == roomnumber);
            return result.ProjectToList<SuoRoomDto>();
        }

        public void DeleteSuoRoom(int id)
        {
            _suoroomRepository.Delete(id);
        }


        public void Addmenu(MenuDto menu)
        {
            Domain.Menu model = AutoMapper.Mapper.Map<Domain.Menu>(menu);
            _menuRepository.Insert(model);

        }

        public void Updatemenu(MenuDto menu)
        {
            Domain.Menu model = AutoMapper.Mapper.Map<Domain.Menu>(menu);
            _menuRepository.Update(model);

        }

        public MenuDto GetmenuById(int id)
        {
            return _menuRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<MenuDto>();
        }

        public List<MenuDto> GetmenuList()
        {
            var result = _menuRepository.TableNoTracking;
          
            return result.ProjectToList<MenuDto>();
        }

        public IPagedList<MenuDto> GetmenuList(int pageindex,int pagesize)
        {
            var result = _menuRepository.TableNoTracking;

            return new PagedList<MenuDto>(result.ProjectToQueryable<MenuDto>(), pageindex, pagesize);
        }

        public void Deletemenu(int id)
        {
            _menuRepository.Delete(id);
        }


        public void AddShift_Exc(Shift_ExcDto Shift_Exc)
        {
            Domain.Shift_Exc model = AutoMapper.Mapper.Map<Domain.Shift_Exc>(Shift_Exc);
            _shift_excRepository.Insert(model);

        }

        public void UpdateShift_Exc(Shift_ExcDto Shift_Exc)
        {
            Domain.Shift_Exc model = AutoMapper.Mapper.Map<Domain.Shift_Exc>(Shift_Exc);
            _shift_excRepository.Update(model);

        }

        public Shift_ExcDto GetShift_ExcById(int id)
        {
            return _shift_excRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<Shift_ExcDto>();
        }

        public List<Shift_ExcDto> GetShift_ExcList()
        {
            var result = _shift_excRepository.TableNoTracking;

            return result.ProjectToList<Shift_ExcDto>();
        }

        public IPagedList<Shift_ExcDto> GetShift_ExcList(int pageindex, int pagesize)
        {
            var result = _shift_excRepository.TableNoTracking;

            return new PagedList<Shift_ExcDto>(result.ProjectToQueryable<Shift_ExcDto>(), pageindex, pagesize);
        }

        public void DeleteShift_Exc(int id)
        {
            _shift_excRepository.Delete(id);
        }


        public void Addreal_mode(real_modeDto real_mode)
        {
            Domain.real_mode model = AutoMapper.Mapper.Map<Domain.real_mode>(real_mode);
            _real_modeRepository.Insert(model);

        }

        public void Updatereal_mode(real_modeDto real_mode)
        {
            Domain.real_mode model = AutoMapper.Mapper.Map<Domain.real_mode>(real_mode);
            _real_modeRepository.Update(model);

        }

        public real_modeDto Getreal_modeById(int id)
        {
            return _real_modeRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<real_modeDto>();
        }

        public List<real_modeDto> Getreal_modeList()
        {
            var result = _real_modeRepository.TableNoTracking;

            return result.ProjectToList<real_modeDto>();
        }

        public IPagedList<real_modeDto> Getreal_modeList(int pageindex, int pagesize)
        {
            var result = _real_modeRepository.TableNoTracking;

            return new PagedList<real_modeDto>(result.ProjectToQueryable<real_modeDto>(), pageindex, pagesize);
        }

        public void Deletereal_mode(int id)
        {
            _real_modeRepository.Delete(id);
        }

        public void AddRemaker(RemakerDto Remaker)
        {
            Domain.Remaker model = AutoMapper.Mapper.Map<Domain.Remaker>(Remaker);
            _remakerRepository.Insert(model);

        }

        public void UpdateRemaker(RemakerDto Remaker)
        {
            Domain.Remaker model = AutoMapper.Mapper.Map<Domain.Remaker>(Remaker);
            _remakerRepository.Update(model);

        }

        public RemakerDto GetRemakerById(int id)
        {
            return _remakerRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<RemakerDto>();
        }

        public List<RemakerDto> GetRemakerList()
        {
            var result = _remakerRepository.TableNoTracking;

            return result.ProjectToList<RemakerDto>();
        }

        public IPagedList<RemakerDto> GetRemakerList(int pageindex, int pagesize)
        {
            var result = _remakerRepository.TableNoTracking;

            return new PagedList<RemakerDto>(result.ProjectToQueryable<RemakerDto>(), pageindex, pagesize);
        }

        public void DeleteRemaker(int id)
        {
            _remakerRepository.Delete(id);
        }

        public void AddSincethehous(SincethehousDto Sincethehous)
        {
            Domain.Sincethehous model = AutoMapper.Mapper.Map<Domain.Sincethehous>(Sincethehous);
            _sincethehousRepository.Insert(model);

        }

        public void UpdateSincethehous(SincethehousDto Sincethehous)
        {
            Domain.Sincethehous model = AutoMapper.Mapper.Map<Domain.Sincethehous>(Sincethehous);
            _sincethehousRepository.Update(model);

        }

        public SincethehousDto GetSincethehousById(int id)
        {
            return _sincethehousRepository.TableNoTracking.Where(s => s.Id == id).ProjectToFirstOrDefault<SincethehousDto>();
        }

        public List<SincethehousDto> GetSincethehousList()
        {
            var result = _sincethehousRepository.TableNoTracking;

            return result.ProjectToList<SincethehousDto>();
        }

        public IPagedList<SincethehousDto> GetSincethehousList(int pageindex, int pagesize)
        {
            var result = _sincethehousRepository.TableNoTracking;

            return new PagedList<SincethehousDto>(result.ProjectToQueryable<SincethehousDto>(), pageindex, pagesize);
        }

        public void DeleteSincethehous(int id)
        {
            _sincethehousRepository.Delete(id);
        }
    }
}
