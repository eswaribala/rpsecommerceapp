using rpsecommerceapp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace rpsecommerceapp.viewmodels
{
    
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Product> _Products;
        private string _Name,_Photo;    
        public ProductViewModel()
        {
            _Products = new ObservableCollection<Product>();
            _Products.Add(new Product
            {
                ProductId = 1,
                Name = "TV",
                Photo = "tv.jpg",
            
            });
            _Products.Add(new Product
            {
                ProductId = 2,
                Name = "Smart Watch",
                Photo = "smartwatch.jpg",
                
            });
            _Products.Add(new Product
            {
                ProductId = 3,
                Name = "Washing Machine",
                Photo = "washingmachine.jpg",
              
            });
            _Products.Add(new Product
            {
                ProductId = 4,
                Name = "Mobile",
                Photo = "mobile.jpg",
             
            });
           

        }


        public ObservableCollection<Product> Products
        {
            get
            {
                return _Products;
            }
            set
            {
                if (_Products != value)
                {
                    _Products = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Products"));
                }
            }
        }

        public string Name
        {
            get { return _Name; }
            set {  _Name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                    }
        }
        public string Photo
        {
            get { return _Photo; }
            set
            {
                _Photo = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Photo"));
            }
        }
        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
