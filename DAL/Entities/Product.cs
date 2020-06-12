using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string Colour { set; get; }
        public string Price { set; get; }
        public virtual Category Category { set; get; }
    }
}
