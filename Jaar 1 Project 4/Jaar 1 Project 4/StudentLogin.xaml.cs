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


//The username and password are send to the visitor 

namespace Jaar_1_Project_4 {
    public sealed partial class StudentLogin : Page {
        private IClassicOption<string> username; //has the username
        private IClassicOption<string> password;  //Has the password
        private IOptionVisitor<string> loginVisitor; //The visitor
        public StudentLogin() {
            this.username = new NoneLogin(); 
            this.password = new NoneLogin();
            this.loginVisitor = new TheVisitor<string>(); 
            this.InitializeComponent();
           
        }
        private void usernameEntered(object sender, PointerRoutedEventArgs e) {
        }
        private void isEntered(object sender, KeyRoutedEventArgs e) {
            if (e.Key == VirtualKey.Enter) {
                if (UsernameTypeBox.Text.ToString().Length > 0) {
                    username = new SomeUsernameLogin(UsernameTypeBox.Text.ToString());
                    username.ClassicVisit(loginVisitor);
                }
            }
        }
        private void passwordTypeBox_KeyDown(object sender, KeyRoutedEventArgs e) {
                if (e.Key == VirtualKey.Enter) {
                if (UsernameTypeBox.Text.ToString().Length > 0) {
                    password = new SomePasswordLogin(UsernameTypeBox.Text.ToString());
                    username.ClassicVisit(loginVisitor);                                   
                }
            }
        }
        private void createButton_Click(object sender, RoutedEventArgs e) {
            loginVisitor.OnLoginCheck();
            this.Frame.Navigate(typeof(MainMenu));
        }
        private void studentLoginBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(CreateAccount));
        }
    }
}