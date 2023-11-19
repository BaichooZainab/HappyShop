using Microsoft.AspNetCore.Mvc;


namespace HappyShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class registercontroller : Controller
    {
        public IActionResult register()
        {
            return View();
        }
    }
}
