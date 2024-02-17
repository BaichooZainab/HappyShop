
using Hs.DatabaseAccess.Repository.IRepository;
using Hs.Models;
using Hs.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace happyshop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class StaffController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaffController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<Staff> objStaffList = _unitOfWork.Staff.GetAll();
            //or instead of var you can also use List (preferred)

            return View(objStaffList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Staff staff = new();

            {
                 //Name = "",
                 //StreetAddress = "",
                 //City = "",
                 //State = "",

            };


            if (id == null || id == 0)
            {
                //create
                return View(staff);
            }
            else
            {
                //update
                staff = _unitOfWork.Staff.Get(u => u.Id == id);
                return View(staff);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Staff staff)
        {


            if (ModelState.IsValid)
            {

                if (staff.Id == 0)
                {
                    _unitOfWork.Staff.Add(staff);
                }
                else
                {
                    _unitOfWork.Staff.Update(staff);
                }

                _unitOfWork.Save();
                TempData["success"] = "Staff created successfully";

                return RedirectToAction("Index");
            }
            else
            {
                

                return View(staff);
            }
        }


        //GET

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
          
            List<Staff> objStaffList = _unitOfWork.Staff.GetAll().ToList();
            return Json(new { data = objStaffList });
        }
        //POST
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var staffToBeDeleted = _unitOfWork.Staff.Get(u => u.Id == id);
            if (staffToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Staff.Remove(staffToBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}


