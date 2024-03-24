using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
