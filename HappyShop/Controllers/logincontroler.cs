using Microsoft.AspNetCore.Mvc;


namespace HappyShop.Controllers
{
    public class logincontroler : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
