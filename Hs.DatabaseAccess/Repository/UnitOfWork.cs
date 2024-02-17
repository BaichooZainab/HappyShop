using Hs.DatabaseAccess.Repositories;
using Hs.DatabaseAccess.Repositories.IRepository;
using Hs.DatabaseAccess.Repository.IRepository;
using Hs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hs.DatabaseAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
		public ICompanyRepository Company { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IStaffRepository Staff { get; private set; }
        public ITestimonialRepository Testimonial { get; private set; }
        public IViewTestimonialRepository ViewTestimonial { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
			Company = new CompanyRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
            Staff = new StaffRepository(_db);
            Testimonial = new TestimonialRepository(_db);
            ViewTestimonial = new ViewTestimonialRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
