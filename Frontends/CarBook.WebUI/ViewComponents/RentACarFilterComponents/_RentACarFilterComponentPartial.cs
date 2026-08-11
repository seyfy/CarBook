using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(string v)
        {
            v = "Selam";
            TempData["value"] = v;        
            return View();
        }
    }
}
