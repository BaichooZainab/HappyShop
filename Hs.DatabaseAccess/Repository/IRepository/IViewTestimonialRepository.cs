using Hs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs.DatabaseAccess.Repositories.IRepository
{
    public interface IViewTestimonialRepository : IRepository<Testimonial>
    {
        void Update(Testimonial obj);
      
    }
}
