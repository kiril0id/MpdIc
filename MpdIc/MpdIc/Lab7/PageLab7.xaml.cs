using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MpdIc.Lab7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLab7 : ContentPage
    {
        public PageLab7()
        {
            Label TxtExercise = new Label
            {
                Text = "Необходимо разместить на сцене кнопку, по нажатию на которую выдается приветствие.",
                VerticalOptions = LayoutOptions.CenterAndExpand,

                // Margin = new Thickness(0,-50,0,0),
                FontSize = 20
            };

            Content = TxtExercise;
        
        }
    }
}