using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.v1 = "About Us";
			ViewBag.v2 = "Our Vision & Mission";

            return View();
		}
	}
}
