using rpsecommerceapp.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rpsecommerceapp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaruoselDemoPage : ContentPage
    {
        public CaruoselDemoPage()
        {
            InitializeComponent();
            var vm = new ProductViewModel();
            this.BindingContext = vm;
        }
    }
}