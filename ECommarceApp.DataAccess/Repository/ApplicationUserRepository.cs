
using ECommarceApp.DataAccess.Data;
using ECommarceApp.DataAccess.Repository.IRepository;
using ECommarceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommarceApp.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }

}
