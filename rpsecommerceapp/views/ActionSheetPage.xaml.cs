using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Button DecisionActionSheet = new Button
            {
                Text = "Yes No Action Sheet"
            };

            SimpleActionSheet.Clicked += async delegate
              {
                  await DisplayActionSheet("Offers", "Share", null, 
                      "Analog Watches", "Jewellery", "Garments");
              };
            DecisionActionSheet.Clicked += async delegate
              {
                  var action = await DisplayActionSheet("Offers", "Yes", 
                      "No", "Analog Watches", "Jewellery", "Garments");
                  Debug.WriteLine(action);
                  if (action.Equals("View"))
                  {

                  }
              };
            ActionSheetStack.Children.Add(SimpleActionSheet);
            ActionSheetStack.Children.Add(DecisionActionSheet);
        }
    }
}