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
    public partial class StoreTab : TabbedPage
    {
        public StoreTab()
        {
            InitializeComponent();
            Label ProductLabel1 = new Label
            {
                Text = "Robotic Vaccum Cleaner",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                //HorizontalTextAlignment = TextAlignment.Center
            };
            Label ProductLabel2 = new Label
            {
                Text = "X-Ray",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                //HorizontalTextAlignment = TextAlignment.Center
            };
            var ProductRealativeLayout = new RelativeLayout();
            ProductRealativeLayout.Children.Add(ProductLabel1, Constraint.Constant(50),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height / 4;
                }));
            ProductRealativeLayout.Children.Add(ProductLabel2,
               Constraint.Constant(0),
               Constraint.RelativeToView(ProductLabel1, (parent, sibling) => {
                   return sibling.Height / 2;
               }));
            ProductGallery.Content = ProductRealativeLayout;
            Label CartLabel = new Label
            {
                Text = "My Cart",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                //HorizontalTextAlignment = TextAlignment.Center
            };
            var CartRealativeLayout = new RelativeLayout();
            CartRealativeLayout.Children.Add(CartLabel, Constraint.Constant(50),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height / 4;
                }));

            Cart.Content = CartRealativeLayout;

            Label OrderLabel = new Label
            {
                Text = "My Orders",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                //HorizontalTextAlignment = TextAlignment.Center
            };
            var OrderRealativeLayout = new RelativeLayout();
            OrderRealativeLayout.Children.Add(OrderLabel, Constraint.Constant(75),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height / 6;
                }));

            Orders.Content = OrderRealativeLayout;
        }
    }
}