using HoteManagement.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteManagement.Service.Sys
{
    public interface ISysService
    {
        int GetBannerCount();



        void AddBanner(bannerDto bannerDto);


        IPagedList<bannerDto> GetBannerPageList(int pageindex, int pagesize);


        bannerDto GetBannerByBannerId(string id);


        void UpdateBanner(bannerDto banner);


        SysParamterDto GetSysParamterById(int id);


        List<cCallDto> GetCCallList();


        cCallDto GetCCall(int id);



        List<cpTypeDto> GetcptypeList();

        cpTypeDto Getcptype(int id);



        List<cDepartmentDto> GetcDepartmentList();


        cDepartmentDto GetcDepartment(int id);



        List<cPostDto> GetcPostList();


        cPostDto GetcPost(int id);


        List<csysTypeDto> GetcsysTypeList();


        List<customerTypeDto> GetcustomerTypeList();


        List<customerStateDto> GetcustomerStateList();


        customerStateDto GetcustomerState(int id);




        List<cIndustryDto> GetcIndustryList();


        cIndustryDto GetcIndustry(int id);


        List<cost_typeDto> GetCostType(int? ct_iftype, int? ct_categories);



        GoodsDto GetGoods(int id);
        

    }
}
