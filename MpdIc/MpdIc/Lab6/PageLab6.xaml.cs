using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MpdIc.Lab6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLab6 : ContentPage
    {
        public PageLab6()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            studentList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            StudentPage studentPage = new StudentPage();
            studentPage.BindingContext = selectedStudent;
            await Navigation.PushAsync(studentPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateStudent(object sender, EventArgs e)
        {
            Student student = new Student();
            StudentPage studentPage = new StudentPage();
            studentPage.BindingContext = student;
            await Navigation.PushAsync(studentPage);
        }
    }
}