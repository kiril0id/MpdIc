using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MpdIc.Lab8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLab8 : ContentPage
    {
        public PageLab8()
        {
            InitializeComponent();
        }
        private void History(object sender, EventArgs e)
        {
            webView.GoBack();

        }
        void button_Clicked(object sender, EventArgs e)
        {

            webView.Source = new UrlWebViewSource { Url = urlEntry.Text };

        }
    }
}