using rpsecommerceapp.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rpsecommerceapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            List<Color> ColorList = new List<Color>();
            ColorList.Add(Color.Blue);
            ColorList.Add(Color.Green);
            ColorList.Add(Color.Violet);
            ColorList.Add(Color.Pink);
            ColorList.Add(Color.Magenta);
            ColorList.Add(Color.Violet);
            ColorList.Add(Color.Pink);
            List<String> imageNames = new List<string>();
            imageNames.Add("mobile.jpg");
            imageNames.Add("tv.jpg");
            imageNames.Add("smartwatch.jpg");
            imageNames.Add("washingmachine.jpg");
            imageNames.Add("mobile.jpg");
            imageNames.Add("tv.jpg");
            imageNames.Add("smartwatch.jpg");
            imageNames.Add("washingmachine.jpg");
            /*
            RowDefinition row = new RowDefinition();
            row.Height = new GridLength(1.0, GridUnitType.Star);
           
            NewArrivalGrid.RowDefinitions.Add(new RowDefinition
           { Height=new GridLength(1.0, GridUnitType.Star) });
            NewArrivalGrid.RowDefinitions.Add(new RowDefinition
            { Height=new GridLength(1.0, GridUnitType.Star) });
            NewArrivalGrid.RowDefinitions.Add(new RowDefinition
            { Height = new GridLength(1.0, GridUnitType.Star) });
           NewArrivalGrid.ColumnDefinitions.Add(new ColumnDefinition
           { Width= new GridLength(1.0, GridUnitType.Star) });
          NewArrivalGrid.ColumnDefinitions.Add(new ColumnDefinition{
          Width= new GridLength(1.0, GridUnitType.Star) });
           */
            for (int rowIndex = 0; rowIndex < 7; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 2; columnIndex++)
                {

                    var box = new BoxView
                    {
                        BackgroundColor = Color.White,
                        WidthRequest=50,
                        HeightRequest=50

                    };
                    var image = new Image
                    {
                        Source = imageNames[rowIndex],
                        HeightRequest=50,
                        WidthRequest=50
                    };
                    NewArrivalGrid.Children.Add(box, columnIndex, rowIndex);
                    NewArrivalGrid.Children.Add(image, columnIndex, rowIndex);
                }
            }

            var button = new Button
            {
                Text = "Visit Store",
                BackgroundColor = Color.Navy,
                TextColor = Color.White,
                //WidthRequest=50,
                //HeightRequest=50
                
                
            };
            button.Clicked += async delegate
              {
                  await Navigation.PushModalAsync(new NavigationPage(new StoreTab()));
              };

            var stackLayout = new StackLayout();
           // stackLayout.WidthRequest = 50;
            //stackLayout.HeightRequest = 50;
            stackLayout.Children.Add(button);
            topStack.Children.Add(stackLayout);

        }

        protected async override void OnAppearing()
        {
           base.OnAppearing();
            await Task.Delay(10000);
            await Navigation.PushModalAsync(new NavigationPage(new StoreTab()));
        }
        /*
        private void Store_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new StoreTab()));
        }
        */
    }

   
}
