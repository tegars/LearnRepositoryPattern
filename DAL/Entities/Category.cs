using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Name { set; get; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
