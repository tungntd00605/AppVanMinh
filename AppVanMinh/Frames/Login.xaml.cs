using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
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
        private static String API_LOGIN = "https://2-dot-backup-server-002.appspot.com/_api/v2/members/authentication";

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<String, String> memberLogin = new Dictionary<string, string>();
            memberLogin.Add("email", "xuanhung2401@gmail.com");
            memberLogin.Add("password", "123");
            HttpClient httpClient = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(memberLogin), System.Text.Encoding.UTF8, "application/json");
            var a = await httpClient.PostAsync(API_LOGIN, content).Result.Content.ReadAsStringAsync();
            Debug.WriteLine(a);
        }
    }
}
