using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs.Models.ViewModel
{
    public class IndexVM
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
