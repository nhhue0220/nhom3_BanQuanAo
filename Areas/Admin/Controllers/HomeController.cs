using Microsoft.AspNetCore.Mvc;

namespace Nhom3_BanQuanAo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
