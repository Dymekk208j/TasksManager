using System.Collections.Generic;
using System.Web.Mvc;
using TasksMenager.Models.DatabaseModels;
using System.Linq;
using TasksMenager.Models.ViewModels;

namespace TasksMenager.Controllers
{
    public class CompanyListController : Controller
    {
        // GET: CompanyList
        [HttpGet]
        public ActionResult Index(int page)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var list = (from n in db.Companies select n).OrderBy(n=>n.CompanyId).Skip(page*10).Take(10).ToList();
            int count = (from n in db.Companies select n).Count();

            CompanyListViewModel companyListViewModel = new CompanyListViewModel
            {
                Comapnies = AutoMapper.Mapper.Map<List<Company>, List<CompanyViewModel>>(list),
                NextPage = (count > ((page + 1) * 10)),
                Page = page,
                PreviousPage = (page > 0)
            };

            return View(companyListViewModel);
        }
    }
}