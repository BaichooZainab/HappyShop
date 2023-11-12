
using Hs.DatabaseAccess;
using Microsoft.AspNetCore.Mvc;


namespace Hs.Models
{
    public class ProductContoller : Controller
    {

        private readonly ApplicationDbContext _db;

        public ProductContoller(ApplicationDbContext db)
        {

            _db = db;

        }

        public IActionResult Index()
        {

            IEnumerable<Product> objProductList = _db.Products;
            //or instead of var you can also use List (preferred)
            // List<Category> objCategoryList = _db.Categories.ToList(); 

            return View(objProductList);
        }

        //GET
        public IActionResult Add()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product obj)
        {
            if (obj.pname == obj.Quantity.ToString())
            {
                ModelState.AddModelError("Quantity", "The Quantity cannot exactly match the Product Name. ");
            }


            if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Product added successfully";

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        



    }
}
