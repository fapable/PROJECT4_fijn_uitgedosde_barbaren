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
using Jaar_1_Project_4.QuestionSystem;

//The student login page

namespace Jaar_1_Project_4 {
    public sealed partial class StudentLogin : Page {
        private IUserNameAndPasswordVisit<string> username; //Stores username
        private IUserNameAndPasswordVisit<string> password; //Stores password
        private ILoginVisitor<string> loginVisitor; //To check the username and password
        public StudentLogin() {
            this.username = new NoneLogin();
            this.password = new NoneLogin();
            this.loginVisitor = new LogInInformationStoreVisitor<string>();
            this.InitializeComponent();
        }
        //Checks if username and password is typed in and then visits the username and password
        private void LoginButtonClick(object sender, RoutedEventArgs e) {
            if (UsernameTypeBox.Text.ToString().Length > 0) {
                username = new SomeUsernameLogin(UsernameTypeBox.Text.ToString()); //Username is now a Some because it's not empty
                username.NoLamdaVisit(loginVisitor); //Username calls it's visit method
            }
            else {
                //TODO with the use of factory, make a label that says that the username is not filled in
            }
            if (passwordBox.Password.ToString().Length > 0) {
                password = new SomePasswordLogin(passwordBox.Password.ToString()); //password is now a some because ít's not empty
                password.NoLamdaVisit(loginVisitor); //Password calls it's visit method
            }
            loginVisitor.OnLoginCheck(); //The filled in username and password are now checked
            this.Frame.Navigate(typeof(mainQpage));
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainLoginPage));
        }
    }
}