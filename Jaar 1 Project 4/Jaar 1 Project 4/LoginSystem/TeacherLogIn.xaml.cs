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

//The teacher login page
//See the student login page for the comments

namespace Jaar_1_Project_4 {
    public sealed partial class TeacherLogIn : Page {
        private IUserNameAndPasswordVisit<string> username;
        private IUserNameAndPasswordVisit<string> password;
        private ILoginVisitor<string> loginVisitor;
        public TeacherLogIn() {
            this.username = new NoneLogin();
            this.password = new NoneLogin();
            this.loginVisitor = new LogInInformationStoreVisitor<string>();
            this.InitializeComponent();
        }
        private void LogInButtonClick(object sender, RoutedEventArgs e) {
            if (UsernameTypeBox.Text.ToString().Length > 0) {
                username = new SomeUsernameLogin(UsernameTypeBox.Text.ToString()); 
                username.NoLamdaVisit(loginVisitor); 
            }
            else {
                //TODO with the use of factory, make a label that says that the username is not filled in
            }
            if (passwordBox.Password.ToString().Length > 0) {
                password = new SomePasswordLogin(passwordBox.Password.ToString());
                password.NoLamdaVisit(loginVisitor);
            }
            loginVisitor.OnLoginCheck();
            this.Frame.Navigate(typeof(Questions));
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainLoginPage));
        }
    }
}

