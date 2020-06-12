using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.Models
{
    public class CategoryIndexVM
    {
        public String Test { set; get; }
        public List<Category> categories { set; get; } = new List<Category>();
    }
}
