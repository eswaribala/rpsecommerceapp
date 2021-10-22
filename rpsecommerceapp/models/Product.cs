using System;
using System.Collections.Generic;
using System.Text;

namespace rpsecommerceapp.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
      
        public string Photo { get; set; }

        public long Price { get; set; }

        public int AvailableQty { get; set; }

    }
}
