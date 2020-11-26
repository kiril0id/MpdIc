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
    public partial class StudentPage : ContentPage
    {
        public StudentPage()
        {
            InitializeComponent();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
        private void DeleteStudent(object sender, EventArgs e)
        {
            var student = (Student)BindingContext;
            App.Database.DeleteItem(student.Id);
            this.Navigation.PopAsync();
        }
        private void SaveStudent(object sender, EventArgs e)
        {
            var student = (Student)BindingContext;
            if (!String.IsNullOrEmpty(student.LastName))
            {
                App.Database.SaveItem(student);
            }
            this.Navigation.PopAsync();

        }
    }
}
