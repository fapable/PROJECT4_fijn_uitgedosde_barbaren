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
using Windows.System;
using System.Diagnostics;


//The username and password are boxed as Some or none and then send to the visitor

namespace Jaar_1_Project_4 {
    public sealed partial class StudentLogin : Page {
        private IClassicOption<string> username;
        private IClassicOption<string> password;
        private IOptionVisitor<string> loginVisitor;
        public StudentLogin() {
            this.username = new NoneLogin();
            this.password = new NoneLogin();
            this.loginVisitor = new TheVisitor<string>();
            this.InitializeComponent();
        }
        private void CreateButtonClick(object sender, RoutedEventArgs e) {
            if (UsernameTypeBox.Text.ToString().Length > 0) {
                username = new SomeUsernameLogin(UsernameTypeBox.Text.ToString()); //Username is now a Some because it's not empty
                username.ClassicVisit(loginVisitor); //Username calls it's visit method
            }
            else {
                //TODO with the use of factory, make a label that says that the username is not filled in
            }
            if (passwordBox.Password.ToString().Length > 0) {
                password = new SomePasswordLogin(passwordBox.Password.ToString());
                password.ClassicVisit(loginVisitor);
            }
            loginVisitor.OnLoginCheck(); //The filled in username and password are now checked
            this.Frame.Navigate(typeof(Questions));
        }
        private void studentLoginBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainLoginPage));
        }
        private void button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(CreateAccount));
        }
    }
}