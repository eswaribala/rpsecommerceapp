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
    public partial class ActionSheetPage : ContentPage
    {
        public ActionSheetPage()
        {
            InitializeComponent();

            Button SimpleActionSheet = new Button
            {
                Text = "Simple Action Sheet"
            };

            Button YesNoActionSheet = new Button
            {
                Text = "Yes No Action Sheet"
            };

            SimpleActionSheet.Clicked += async delegate
              {
                  await DisplayActionSheet("Offers", "Share", null, 
                      "Analog Watches", "Jewellery", "Garments");
              };
            YesNoActionSheet.Clicked += async delegate
              {
                  var action = await DisplayActionSheet("Offers", "Share", 
                      "View", "Analog Watches", "Jewellery", "Garments");
  
              };
            ActionSheetStack.Children.Add(SimpleActionSheet);
            ActionSheetStack.Children.Add(YesNoActionSheet);
        }
    }
}