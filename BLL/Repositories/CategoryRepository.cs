using BLL.Interfaces;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public int Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            IList<Category> categories = new List<Category>();
            try
            {
                using (DBContext context = new DBContext())
                {
                    categories = context.Categories.OrderBy(x => x.Name).ToList();
                }
            }
            catch(Exception ex)
            {

            }
            return categories;
        }

        public Category GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Save(Category obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
