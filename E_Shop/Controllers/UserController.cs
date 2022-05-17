using Microsoft.AspNetCore.Mvc;

namespace E_Shop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
