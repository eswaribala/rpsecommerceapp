using rpsecommerceapp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace rpsecommerceapp.viewmodels
{
    
    public class ProductViewModel
    {
        private ObservableCollection<Product> _products;

        public ProductViewModel()
        {
            _products = new ObservableCollection<Product>();
            _products.Add(new Product
            {
                ProductId = 1,
                Name = "TV",
                Photo = "tv.jpg",
                Price = 45000
            });
            _products.Add(new Product
            {
                ProductId = 2,
                Name = "Smart Watch",
                Photo = "smartwatch.jpg",
                Price = 25000
            });
            _products.Add(new Product
            {
                ProductId = 3,
                Name = "Washing Machine",
                Photo = "washingmachine.jpg",
                Price = 65000
            });
            _products.Add(new Product
            {
                ProductId = 4,
                Name = "Mobile",
                Photo = "mobile.jpg",
                Price = 25000
            });
           

        }

    }
}
