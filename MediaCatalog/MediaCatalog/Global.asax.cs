using AutoMapper;
using MediaCatalog.Data;
using MediaCatalog.Domain;
using MediaCatalog.Models;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MediaCatalog
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<AppContext>(null);
            InitializeAutomapper();

        }

        private void InitializeAutomapper()
        {
            Mapper.CreateMap<Media, MediaViewModel>();
            Mapper.CreateMap<Media, CreateMediaViewModel>().ReverseMap().ForMember(m => m.CompanyId, opt => opt.Ignore());
            Mapper.CreateMap<Person, PersonViewModel>();
            Mapper.CreateMap<Company, CompanyViewModel>();
        }
    }
}