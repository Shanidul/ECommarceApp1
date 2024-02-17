using ECommarceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommarceApp.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository: IRepositoryAsync<Category>
    {
        void Update(Category category);
    }
}
