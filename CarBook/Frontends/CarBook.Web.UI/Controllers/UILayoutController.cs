using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
