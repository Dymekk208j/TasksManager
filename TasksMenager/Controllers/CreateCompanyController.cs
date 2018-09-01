using System.Web.Mvc;
using TasksMenager.Models.DatabaseModels;
using TasksMenager.Models.ViewModels;

namespace TasksMenager.Controllers
{
    public class CreateCompanyController : Controller
    {
        // GET: CreateCompany
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewCompany(CompanyViewModel companyViewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = new ApplicationDbContext();
                Company company = AutoMapper.Mapper.Map<CompanyViewModel, Company>(companyViewModel);

                db.Companies.Add(company);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else return View("Index", companyViewModel);


        }
    }
}