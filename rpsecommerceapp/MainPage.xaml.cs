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

           // RowDefinition row = new RowDefinition();
            //row.Height = new GridLength(1.0, GridUnitType.Star);
           
          //  NewArrivalGrid.RowDefinitions.Add(new RowDefinition
         //  { Height=new GridLength(1.0, GridUnitType.Star) });
           // NewArrivalGrid.RowDefinitions.Add(new RowDefinition
           // { Height=new GridLength(1.0, GridUnitType.Star) });
          //  NewArrivalGrid.RowDefinitions.Add(new RowDefinition
          //  { Height = new GridLength(1.0, GridUnitType.Star) });
          // NewArrivalGrid.ColumnDefinitions.Add(new ColumnDefinition
          // { Width= new GridLength(1.0, GridUnitType.Star) });
           //NewArrivalGrid.ColumnDefinitions.Add(new ColumnDefinition{
           //Width= new GridLength(1.0, GridUnitType.Star) });

            for (int rowIndex = 0; rowIndex < 7; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 2; columnIndex++)
                {

                    var box = new BoxView
                    {
                        BackgroundColor = ColorList[rowIndex]

                    };
                    var label = new Label
                    {
                        Text="XAMRAIN"
                    };
                    NewArrivalGrid.Children.Add(box, columnIndex, rowIndex);
                    NewArrivalGrid.Children.Add(label, columnIndex, rowIndex);
                }
            }
            
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new NavigationPage(new StoreTab()));
        //}
    }
}
