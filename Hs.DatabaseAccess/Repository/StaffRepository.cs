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
	public class StaffRepository : Repository<Staff>, IStaffRepository
    {
		private ApplicationDbContext _db;
		public StaffRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}


		public void Update(Staff obj)
		{
            var objFromDb = _db.Staffs.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.StreetAddress = obj.StreetAddress;
                objFromDb.State = obj.State;
                objFromDb.City = obj.City;
                objFromDb.Email = obj.Email;
                objFromDb.Password = obj.Password;
                objFromDb.PhoneNumber = obj.PhoneNumber;
               
             
            }
        }
	}
}
