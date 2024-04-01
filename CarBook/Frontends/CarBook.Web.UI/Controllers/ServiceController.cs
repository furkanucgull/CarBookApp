using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
