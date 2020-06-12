using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    class Category : BaseEntity
    {
        public string Name { set; get; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
