
using Hs.DatabaseAccess;
using Hs.DatabaseAccess.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;


namespace Hs.Models
{
    public class CategoryContoller : Controller
    {

        private readonly ICategoryRepository _categoryRepo;

        public CategoryContoller(ICategoryRepository db)
        {

            _categoryRepo = db;

        }

        public IActionResult Index()
        {

            IEnumerable<Category> objCategoryList = _categoryRepo.GetAll();
            //or instead of var you can also use List (preferred)
            // List<Category> objCategoryList = _db.Categories.ToList(); 

            return View(objCategoryList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "The DisplayOrder cannot exactly match the Name. ");
            }


            if (ModelState.IsValid)
            {
                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category created successfully";

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _categoryRepo.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "The DisplayOrder cannot exactly match the Name. ");
            }
            if (ModelState.IsValid)
            {
                _categoryRepo.Update(obj);
                _categoryRepo.Save();
                TempData["success"] = "Category Updated successfully";

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _categoryRepo.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _categoryRepo.Get(u => u.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            _categoryRepo.Remove(obj);
            _categoryRepo.Save();
            TempData["success"] = "Category deleted successfully";

            return RedirectToAction("Index");
        }




    }
}
