using System;
using System.Collections.Generic;
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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppVanMinh.Frames
{
    public sealed partial class Login : ContentDialog
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void Sign_Up(object sender, TappedRoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            this.Hide();
            rootFrame.Navigate(typeof(Sign));
        }

        private void Login_Handle(object sender, TappedRoutedEventArgs e)
        {
            var username = Username.Text;
            var password = Password.Password.ToString();
            if(username == "")
            {
                Username_Message.Text = "Username khong duoc de trong!";
                Username_Message.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            } else
            {
                Username_Message.Text = "";
            }
            if (password == "")
            {
                Password_Message.Text = "Mat khau khong duoc de trong!";
                Password_Message.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            } else
            {
                Password_Message.Text = "";
            }
            if(username != "" && password != "")
            {
                this.Hide();
            }
        }
    }
}
