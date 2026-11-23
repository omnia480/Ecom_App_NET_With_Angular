using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecom.Core.Enities.product
{

    public class Product : BaseEnity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual List<Photo> Photos { get; set; }

        public int categoryId { get; set; }
        [ForeignKey (name:nameof(categoryId))]
        public virtual Category category { get; set; }
    }
}


