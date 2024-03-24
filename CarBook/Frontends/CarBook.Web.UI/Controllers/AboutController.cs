using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
