﻿using System.Collections.Generic;

namespace OA1.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string SupplierName { get; set; }
        public List<Product> Products { get; set; }
    }
}
