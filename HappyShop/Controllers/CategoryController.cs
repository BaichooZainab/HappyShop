﻿using HappyShop.Data;
using Microsoft.AspNetCore.Mvc;


namespace HappyShop.Models
{
    public class CategoryContoller : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryContoller(ApplicationDbContext db)
        {

            _db = db;

        }

        public IActionResult Index()
        {

            IEnumerable<Category> objCategoryList = _db.Categories;
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
                _db.Categories.Add(obj);
                _db.SaveChanges();
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
            var categoryFromDb = _db.Categories.Find(id);

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
                _db.Categories.Update(obj);
                _db.SaveChanges();
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
            var categoryFromDb = _db.Categories.Find(id);

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
            var obj = _db.Categories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";

            return RedirectToAction("Index");
        }




    }
}