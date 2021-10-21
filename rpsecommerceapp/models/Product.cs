using System;
using System.Collections.Generic;
using System.Text;

namespace rpsecommerceapp.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Photo { get; set; }
    }
}
