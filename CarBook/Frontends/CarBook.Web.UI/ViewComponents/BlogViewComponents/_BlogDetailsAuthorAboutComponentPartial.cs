﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsAuthorAboutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
