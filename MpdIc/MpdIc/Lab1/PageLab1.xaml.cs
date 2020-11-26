using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MpdIc.Lab1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLab1 : ContentPage
    {
       
        public PageLab1()
        {
            Label TxtExercise = new Label
            {
                Text = "Необходимо разместить на сцене кнопку, по нажатию на которую выдается приветствие.",
                VerticalOptions = LayoutOptions.CenterAndExpand,

                // Margin = new Thickness(0,-50,0,0),
                FontSize = 20
            };
            Button clickButton = new Button

            {
                Text = "Нажми на меня ",
                //Margin = new Thickness(0,50,0,0),
                VerticalOptions = LayoutOptions.CenterAndExpand,

                //HorizontalOptions = LayoutOptions.Center
            };
            clickButton.Clicked += ClickButton_Clicked;
            var stackLayout = new StackLayout()
            {
                Padding = new Thickness(50),
                BackgroundColor = Color.Azure,
                Children = { TxtExercise, clickButton }

            };

            Content = stackLayout;
        }

        private void ClickButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Уведомление", "Рады видеть вас в нашем приложении", "Привет");
        }
    }
}