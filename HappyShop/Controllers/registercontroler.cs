using Microsoft.AspNetCore.Mvc;


namespace HappyShop.Controllers
{
    public class registercontroler : Controller
    {
        public IActionResult register()
        {
            return View();
        }
    }
}
