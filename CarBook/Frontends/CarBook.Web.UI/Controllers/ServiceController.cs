using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Services";
            ViewBag.v2 = "Our Services";

            return View();
        }
    }
}
