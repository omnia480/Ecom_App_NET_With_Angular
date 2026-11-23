using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Core.Enities.product
{
    public class Category:BaseEnity<int>
    {
        public string Name { get; set; }
        public string Description {get; set; } 
        public ICollection<Product> products { get; set; } = new HashSet<Product>();
    }
}
