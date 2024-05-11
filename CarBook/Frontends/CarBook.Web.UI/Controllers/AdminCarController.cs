using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
