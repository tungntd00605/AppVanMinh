using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppVanMinh.Frames
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Sign : Page
    {
        public Sign()
        {
            this.InitializeComponent();
        }

        private async void Handle_Signup(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Action success.");
        }

        private async void Capture_Photo(object sender, RoutedEventArgs e)
        {
            
        }

        private static async void GetUploadUrl()
        {
            
        }

        public async void HttpUploadFile(string url, string paramName, string contentType)
        {
            
        }

        private void Select_Gender(object sender, RoutedEventArgs e)
        {
            RadioButton radioGender = sender as RadioButton;
            //Debug.WriteLine(this.currentMember.gender);
        }

        private void Change_Birthday(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            //this.currentMember.birthday = sender.Date.Value.ToString("yyyy-MM-dd");
        }

        private void Sign_In(object sender, TappedRoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MainPage));
        }

        private void Handle_Signup(object sender, TappedRoutedEventArgs e)
        {
            var email = Email.Text;
            var password = Password.Password;
            var confirm_password = Confirm_Password.Password;
            var firstname = FirstName.Text;
            var lastname = LastName.Text;
            var avatar = ImageUrl.Text;
            var phone = Phone.Text;
            var address = Address.Text;
            var intro = Introduction.Text;
            var birthday = BirthDay.Date;
        }
    }
}
