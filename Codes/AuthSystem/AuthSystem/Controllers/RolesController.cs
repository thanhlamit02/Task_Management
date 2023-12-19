using Microsoft.AspNetCore.Mvc;

namespace AuthSystem.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
