using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plugin.Toast;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MpdIc.Lab3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLab3 : ContentPage
    {
        public PageLab3()
        {
            InitializeComponent();
        }
        private void ColorButton_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var colorbutton = new Color();
            switch (button.Text)
            {
                case "Green": colorbutton = Color.Green; break;
                case "Blue": colorbutton = Color.Blue; break;
                case "Red": colorbutton = Color.Red; break;
                case "Yellow": colorbutton = Color.Yellow; break;



            }
            stackLayout.BackgroundColor = colorbutton;


            CrossToastPopUp.Current.ShowToastMessage(button.Text);

        }

        private void Developer_Clicked(object sender, EventArgs e)
        {
            CrossToastPopUp.Current.ShowToastWarning("by k.tigrik");
        }
    }
}