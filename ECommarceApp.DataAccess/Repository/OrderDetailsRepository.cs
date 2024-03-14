
using ECommarceApp.DataAccess.Data;
using ECommarceApp.DataAccess.Repository.IRepository;
using ECommarceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommarceApp.DataAccess.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(OrderDetails obj)
        {
            _db.Update(obj);
        }
    }

}
