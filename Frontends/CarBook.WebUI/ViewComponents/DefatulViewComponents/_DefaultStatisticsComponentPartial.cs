using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.DefatulViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
