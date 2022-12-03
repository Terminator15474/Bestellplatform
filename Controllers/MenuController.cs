using Microsoft.AspNetCore.Mvc;

namespace Bestellplatform.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
