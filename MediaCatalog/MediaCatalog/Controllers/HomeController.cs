using System.Linq;
using System.Web.Mvc;
using MediaCatalog.Data;

namespace MediaCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContext db = new AppContext();

        public ActionResult Index()
        {

            //var svc = new country();
            //var list = svc.GetCountries(); 

            //foreach (var cultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            //{
            //    RegionInfo info = new RegionInfo(cultureInfo.Name);

            //}
            //var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Where(x => x.Name.Contains("AB")); 


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetStatesList(int? countryId)
        {
            if (countryId != null)
            {
                var list = db.States.Where(x => x.CountryId == countryId).OrderBy(x => x.Abbr);

                return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
            }
            var uslist = db.States.Where(x => x.Country.Abbr == "US").OrderBy(x => x.Abbr);
            return Json(uslist.ToArray(), JsonRequestBehavior.AllowGet);
        }
        

    }
}