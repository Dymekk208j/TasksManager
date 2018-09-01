using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using TasksMenager.Models.DatabaseModels;
using TasksMenager.Models.ViewModels;

namespace TasksMenager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper.Initialize(config =>
            {
                config.CreateMap<CreateProjectViewModel, Project>().ReverseMap();
                config.CreateMap<CompanyViewModel, Company>().ReverseMap();

            });
        }
    }
}
