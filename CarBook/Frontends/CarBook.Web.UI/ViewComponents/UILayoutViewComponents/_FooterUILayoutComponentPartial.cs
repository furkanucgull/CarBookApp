using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
