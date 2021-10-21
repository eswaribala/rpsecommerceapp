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
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
            Button SimpleButton = new Button
            {
                Text = "Simple Alert",
                TextColor = Color.White,
                BackgroundColor = Color.Violet,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(20, 10,20, 10)
            };
            SimpleButton.Clicked += async delegate
             {
                 await DisplayAlert("Alert", "You have been alerted", "OK");
             };
            Button DecisionButton = new Button
            {
                Text = "Decision Alert",
                TextColor = Color.White,
                BackgroundColor = Color.Violet,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(20, 10, 20, 10)
            };

            DecisionButton.Clicked += async delegate
             {
                 var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
                 Debug.WriteLine("Answer: " + answer);
             };

            AlertStack.Children.Add(SimpleButton);
            AlertStack.Children.Add(DecisionButton);
        }
    }
}