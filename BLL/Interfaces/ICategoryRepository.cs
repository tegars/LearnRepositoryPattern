using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace BLL.Interfaces
{
    interface ICategoryRepository : IBaseRepository<Category>
    {
        Category GetById(int Id);
    }
}
