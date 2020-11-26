using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MpdIc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Label header = new Label
            {
                Text = "Список лабараторных заданий ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
             
            string[] labs = new string[] {   "Лабараторная работа №1",
                                             "Лабараторная работа №2",
                                             "Лабараторная работа №3",
                                             "Лабараторная работа №4",
                                             "Лабараторная работа №5",
                                             "Лабараторная работа №6",
                                             "Лабараторная работа №7",
                                             "Лабараторная работа №8",

             };

         
          
            labsView.ItemsSource = labs;
            this.Content = new StackLayout { Children = { header, labsView } };
        }

         async private void LabsView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            switch (e.SelectedItemIndex +1)
            {
                case 1: await Navigation.PushAsync(new Lab1.PageLab1()); break;
                case 2: await Navigation.PushAsync(new Lab2.PageLab2()); break; 
                case 3: await Navigation.PushAsync(new Lab3.PageLab3()); break;  
                case 4: await Navigation.PushAsync(new Lab4.PageLab4()); break;
                case 5: break;
                case 6: await Navigation.PushAsync(new Lab6.PageLab6()); break;
                case 7: break;
                case 8: await Navigation.PushAsync(new Lab8.PageLab8()); break; 
                    

            }
           
            
        }
    }
}
