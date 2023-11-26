using Hs.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HappyShop.Areas.Admin.Controllers
{
    internal class ProductVM
    {
        public IEnumerable<SelectListItem> CategoryList { get; internal set; }
        public Product Product { get; internal set; }
    }
}