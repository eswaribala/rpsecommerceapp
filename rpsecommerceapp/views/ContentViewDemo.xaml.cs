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
    public partial class ContentViewDemo : ContentPage
    {
        public ContentViewDemo()
        {
            InitializeComponent();

            var Data1 = new Label
            {
               
                Text= @"On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.
                 On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.
On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.
                 On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.
On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.
                 On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.",
                TextColor=Color.Navy,
            
                
            };
            var Data2 = new Label
            {
                Text = @"On May 16, 2011, Miguel de Icaza announced on his blog 
               that Mono would be developed and supported by Xamarin, 
                a newly formed company that planned to release a new suite of mobile 
               products. According to de Icaza, at least part of the original 
                  Mono team had moved to the new company.",
                TextColor = Color.Navy,


            };
            var ContentViewRef1 = new ContentView
            {
                BackgroundColor=Color.LightGray,
                WidthRequest=200,
                HeightRequest=200,
                Content=Data1
               
            };
            var ContentViewRef2 = new ContentView
            {
                BackgroundColor = Color.LightCoral,
                WidthRequest = 200,
                HeightRequest = 200,
                Content = Data2

            };

            //ContentStack.Children.Add(ContentViewRef1);
            //ContentStack.Children.Add(ContentViewRef2);

            var scrollView = new ScrollView
            {
                Margin=new Thickness(15),
                Content = Data1,
              
                VerticalScrollBarVisibility=ScrollBarVisibility.Always,
                HorizontalScrollBarVisibility=ScrollBarVisibility.Always
                
                
                
            };
            // ContentStack.Children.Add(scrollView);Bo

            Frame frame = new Frame
            {
                BorderColor = Color.Blue,
               CornerRadius = 10,
               Content=new Image
               {
                   Source="logo.jpg"
                   

               },
               WidthRequest=200,
               HeightRequest=200,
             HorizontalOptions=LayoutOptions.Center,
             VerticalOptions=LayoutOptions.Center,
             TranslationX=100,
             TranslationY=100,
             RotationX=45,
             ScaleX=1,
             ScaleY=1,
               Margin=new Thickness(10),
               HasShadow=true
            
            };
            //ContentStack.Children.Add(frame); 

            Label label1 = new Label
            {
                Text = "Review",
                 TextColor = Color.Green,
                FontAttributes = FontAttributes.Bold

            };
            Label label2= new Label
            {
                Text = "Star Rating",
                TextColor=Color.Navy,
                FontAttributes=FontAttributes.Bold
            };
            Label label3 = new Label
            {
                Text = "Website Url",
                 TextColor = Color.Red,
                FontAttributes = FontAttributes.Bold
            };
            ContentStack.JustifyContent = FlexJustify.SpaceEvenly;
            //ContentStack.AlignItems = FlexAlignItems.Stretch;
            ContentStack.Children.Add(label1);
            ContentStack.Children.Add(label2);
            ContentStack.Children.Add(label3);

        }
    }
}