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
    public partial class ToolbarPage : ContentPage
    {
        public ToolbarPage()
        {
            InitializeComponent();
        }
        async private void AddToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StoreTab());
        }
        async private void EditToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }
    }
}