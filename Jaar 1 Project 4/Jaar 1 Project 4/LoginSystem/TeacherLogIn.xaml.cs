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
using System.Diagnostics;

//The teacher login page
//Main job is to store the typed in usernaem and password, and then they get visited

namespace Jaar_1_Project_4 {
    public sealed partial class TeacherLogIn : Page {
        private IUserNameAndPasswordVisit<string> username; //Username will get stored in here
        private IUserNameAndPasswordVisit<string> password; //password will get stored in here
        private ILoginVisitor<string> loginVisitor; //The visitor
        public TeacherLogIn() {
            this.username = new NoneLogin(); //Username and password are none by default to avoid null's
            this.password = new NoneLogin();
            this.loginVisitor = new LogInInformationStoreVisitor<string>(); 
            this.InitializeComponent();
        }
        //When the user clicks on the login button, this method gets activated
        private void LogInButtonClick(object sender, RoutedEventArgs e) {
                username = new SomeUsernameLogin(UsernameTypeBox.Text.ToString());  //typed in username gets stored 
                password = new SomePasswordLogin(passwordBox.Password.ToString()); //typed in password gets stored
                username.VisitTheLoginInformation(loginVisitor);  //visitor visits the username                               
                password.VisitTheLoginInformation(loginVisitor); //visitor visits the password
                CheckIfLogInIsCorrect(); //the user information gets checked 
        }
        //Goes back to the main login page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainLoginPage));
        }
        //Checks if the given user information is correct
        public void CheckIfLogInIsCorrect() {
            //If the login is correct, the teacher goes to the answer page
            if (loginVisitor.IsLoginInSucceded()) {
                DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter = true; //This way it is know that the login has succeeded, this will be used in parts of the program
                this.Frame.Navigate(typeof(Jaar_1_Project_4.Answer));  //goes to the answer page
            }
            else {
                //If the login is not correct, then an error message is shown
                ErrorTextAttributeFactory.TheErrorTextAttributeFactory(this.errorTextBlock);
            }
        }
    }
}

