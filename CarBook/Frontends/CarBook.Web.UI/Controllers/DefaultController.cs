using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
