
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
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<Company> objCompanyList = _unitOfWork.Company.GetAll();
            //or instead of var you can also use List (preferred)

            return View(objCompanyList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Company company = new();

            {
                 //Name = "",
                 //StreetAddress = "",
                 //City = "",
                 //State = "",

            };


            if (id == null || id == 0)
            {
                //create
                return View(company);
            }
            else
            {
                //update
                company = _unitOfWork.Company.Get(u => u.Id == id);
                return View(company);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Company company)
        {


            if (ModelState.IsValid)
            {

                if (company.Id == 0)
                {
                    _unitOfWork.Company.Add(company);
                }
                else
                {
                    _unitOfWork.Company.Update(company);
                }

                _unitOfWork.Save();
                TempData["success"] = "Company created successfully";

                return RedirectToAction("Index");
            }
            else
            {
                

                return View(company);
            }
        }


        //GET

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
          
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = objCompanyList });
        }
        //POST
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var companyToBeDeleted = _unitOfWork.Company.Get(u => u.Id == id);
            if (companyToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            var usersToDelete = _unitOfWork.ApplicationUser.GetAll(u => u.CompanyId == id);
            foreach (var user in usersToDelete)
            {
                _unitOfWork.ApplicationUser.Remove(user);
            }

            _unitOfWork.Company.Remove(companyToBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}


