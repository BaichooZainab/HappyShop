using Microsoft.AspNetCore.Mvc;


namespace HappyShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class loginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
