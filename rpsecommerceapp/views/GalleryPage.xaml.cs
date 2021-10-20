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
    public partial class GalleryPage : ContentPage
    {
        public GalleryPage()
        {
            InitializeComponent();
            
            var boxView = new BoxView
            {
                BackgroundColor = Color.Blue,
                WidthRequest=300,
                HeightRequest=200
                
                
            };

            var btn1 = new Button
            {
                Text="New Arrivals",
                    WidthRequest = 200,
              HeightRequest = 200
            };

            var btn2 = new Button
            {
                Text = "Clearance Sale",
                   WidthRequest = 200,
               HeightRequest = 200
            };

            var btn3 = new Button
            {
                Text = "Winter Garments"
            };

            var absoluteLayout = new AbsoluteLayout
            {

            };

            absoluteLayout.Children.Add(boxView);
            // AbsoluteLayout.SetLayoutBounds(boxView, new Rectangle(0, 0, 300, 150));
            AbsoluteLayout.SetLayoutBounds(boxView, new Rectangle(0.10, 0.10, 0.30, 0.30));
            AbsoluteLayout.SetLayoutFlags(boxView, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(btn1);
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.10, 0.60, 0.30, 0.20));
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.All);
            absoluteLayout.Children.Add(btn2);
            AbsoluteLayout.SetLayoutBounds(btn2, new Rectangle(0.10, 1.00, 0.30, 0.30));
            AbsoluteLayout.SetLayoutFlags(btn2, AbsoluteLayoutFlags.All);
            GalleryStack.Children.Add(absoluteLayout);
            
            

        }
    }
}