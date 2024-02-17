
using Hs.DatabaseAccess.Repository.IRepository;
using Hs.Models;
using Hs.Models.ViewModel;
using Hs.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;
using System.Security.Claims;

namespace happyshop.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class TestimonialController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TestimonialController(IUnitOfWork unitOfWork, IWebHostEnvironment
webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Testimonial> objTestimonialList = _unitOfWork.Testimonial.GetAll().OrderByDescending(r => r.Date).ToList();
            //or instead of var you can also use List (preferred)

            return View(objTestimonialList);
        }

        //GET
        public IActionResult Create()
        {

            string Name = User.FindFirstValue(ClaimTypes.Name);
            var testimonial = new Testimonial
            {
                Name = Name
            };
            return View(testimonial);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Testimonial obj, IFormFile? file)
        {
           
            if (ModelState.IsValid)
            {

                if (file != null)
                {
                    //try
                    //{
                        string wwwRootPath = _webHostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        string uploadPath = Path.Combine(wwwRootPath, @"images\testimonial");

                        using (var fileStream = new FileStream(Path.Combine(uploadPath, fileName),
                        FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }
                        obj.Image = @"\images\testimonial\" + fileName;

                    //}
                    //catch (Exception ex) 
                    //{
                    //    ModalState.AddModelError(string.Empty, $"An error occurred while uploading the image");
                    //    return View(obj);
                    //}
                }
             
                _unitOfWork.Testimonial.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Testimonial posted successfully";

                return RedirectToAction("Index");
            }

            return View(obj);
        }

       



    }
}


