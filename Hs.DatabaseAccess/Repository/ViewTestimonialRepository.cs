using Hs.DatabaseAccess.Repositories.IRepository;
using Hs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hs.DatabaseAccess.Repositories
{
    public class ViewTestimonialRepository : Repository<Testimonial>, IViewTestimonialRepository
    {
        private ApplicationDbContext _db;
        public ViewTestimonialRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

      

        public void Update(Testimonial obj)
        {
            var objFromDb = _db.Testimonials.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Testimonials = obj.Testimonials;
                if (obj.Image != null)
                {
                    objFromDb.Image = obj.Image;
                }
                objFromDb.Date = obj.Date;
               
              
               
            }
        }
    }
}
