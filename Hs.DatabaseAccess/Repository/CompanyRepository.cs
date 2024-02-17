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
	public class CompanyRepository : Repository<Company>, ICompanyRepository
	{
		private ApplicationDbContext _db;
		public CompanyRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}


		public void Update(Company obj)
		{
            var objFromDb = _db.Companies.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.StreetAddress = obj.StreetAddress;
                objFromDb.State = obj.State;
                objFromDb.City = obj.City;
               
                objFromDb.PostalCode = obj.PostalCode;
               
                objFromDb.PhoneNumber = obj.PhoneNumber;


            }
        }
	}
}
