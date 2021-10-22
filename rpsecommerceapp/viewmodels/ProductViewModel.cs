using rpsecommerceapp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace rpsecommerceapp.viewmodels
{
    
    public class ProductViewModel 
        //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Product> _Products;
        private string _Name,_Photo;
        private long _Price;
        private int _AvailableQty;
        public ProductViewModel()
        {
            _Products = new ObservableCollection<Product>();
            _Products.Add(new Product
            {
                ProductId = 1,
                Name = "TV",
                Photo = "tv.jpg",
                AvailableQty=100,
                Price=45000
            
            });
            _Products.Add(new Product
            {
                ProductId = 2,
                Name = "Smart Watch",
                Photo = "smartwatch.jpg",
                AvailableQty = 1100,
                Price = 4500

            });
            _Products.Add(new Product
            {
                ProductId = 3,
                Name = "Washing Machine",
                Photo = "washingmachine.jpg",
                AvailableQty = 50,
                Price = 15000

            });
            _Products.Add(new Product
            {
                ProductId = 4,
                Name = "Mobile",
                Photo = "mobile.jpg",
                AvailableQty = 10000,
                Price = 15000

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
                 //   OnPropertyChanged(new PropertyChangedEventArgs("Products"));
                }
            }
        }

        public string Name
        {
            get { return _Name; }
            set {  _Name = value;
             //   OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                    }
        }
        public string Photo
        {
            get { return _Photo; }
            set
            {
                _Photo = value;
               // OnPropertyChanged(new PropertyChangedEventArgs("Photo"));
            }
        }

        public long Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
               // OnPropertyChanged(new PropertyChangedEventArgs("Price"));
            }
        }

        public int AvailableQty
        {
            get { return _AvailableQty; }
            set
            {
                _AvailableQty = value;
               // OnPropertyChanged(new PropertyChangedEventArgs("AvailableQty"));
            }
        }


        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            //PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
