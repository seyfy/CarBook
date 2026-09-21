using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminDashBoard")]
    public class AdminDashBoardController : Controller
    {
        [Route("Index")]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
