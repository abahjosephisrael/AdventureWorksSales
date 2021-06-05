using System;
using System.Collections.Generic;

namespace AdventureWorksSales.Web.Models
{    
    public partial class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
