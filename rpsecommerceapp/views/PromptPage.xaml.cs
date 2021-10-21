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
    public partial class PromptPage : ContentPage
    {
        public PromptPage()
        {
            InitializeComponent();
            Button PromptButton = new Button
            {
                Text = "Enter Data"
            };
            PromptButton.Clicked += async delegate
             {
                 await DisplayPromptAsync("Customer Data",
                     "Will you place Order", "OK",
                     "Cancel", keyboard:Keyboard.Text);
 
             };

            PromptStack.Children.Add(PromptButton);
        }
    }
}