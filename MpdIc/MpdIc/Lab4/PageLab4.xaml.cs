using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MpdIc.Lab4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLab4 : ContentPage
    {
        public PageLab4()
        {
            InitializeComponent();
        }
        private void Type_OnChanged(object sender, ToggledEventArgs e)
        {
            var cl = (SwitchCell)sender;
            if (cl.On == true && cl.Text == sin.Text)
            {
                asin.On = false;
            }

            if (cl.On == true && cl.Text == asin.Text)
            {
                sin.On = false;
            }
        }

        async private void Rotate_Clicked(object sender, EventArgs e)
        {
            if (sin.On == true)
            {
                await bsuir.RotateTo(360, UInt32.Parse(time.Text) * 1000);
                bsuir.Rotation = 0;
                await fity.RotateTo(360, UInt32.Parse(time.Text) * 1000);
                fity.Rotation = 0;
            }
            else
            {
                RotationImage(bsuir, time.Text);
                RotationImage(fity, time.Text);


            }

        }

        async private void RotationImage(Image img, string sTime)
        {
            await img.RotateTo(360, UInt32.Parse(sTime) * 1000);
            img.Rotation = 0;
        }

        private void ShowImage_Clicked(object sender, EventArgs e)
        {
            var but = (Xamarin.Forms.Button)sender;
            if (((Xamarin.Forms.Button)sender).Text == "Скрыть")
            {
                bsuir.IsVisible = false;
                fity.IsVisible = false;
                ((Xamarin.Forms.Button)sender).Text = "Показать";
            }
            else
            {
                bsuir.IsVisible = true;
                fity.IsVisible = true;
                ((Xamarin.Forms.Button)sender).Text = "Скрыть";
            }
        }
    }
}