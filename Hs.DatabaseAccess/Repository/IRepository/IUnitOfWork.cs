using Hs.DatabaseAccess.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs.DatabaseAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
		ICompanyRepository Company { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailRepository OrderDetail { get; }
        IStaffRepository Staff { get; }
        ITestimonialRepository Testimonial { get; }
        IViewTestimonialRepository ViewTestimonial { get; }
        void Save();
    }
}
