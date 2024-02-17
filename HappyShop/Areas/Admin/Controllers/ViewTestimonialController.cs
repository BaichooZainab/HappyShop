
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
    public class ViewTestimonialController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ViewTestimonialController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<Testimonial> objViewTestimonialList = _unitOfWork.ViewTestimonial.GetAll();
            //or instead of var you can also use List (preferred)

            return View(objViewTestimonialList);
        }

        

        //GET

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
          
            List<Testimonial> objViewTestimonialList = _unitOfWork.ViewTestimonial.GetAll().ToList();
            return Json(new { data = objViewTestimonialList });
        }
        //POST
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var viewtestimonialToBeDeleted = _unitOfWork.ViewTestimonial.Get(u => u.Id == id);
            if (viewtestimonialToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.ViewTestimonial.Remove(viewtestimonialToBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}


