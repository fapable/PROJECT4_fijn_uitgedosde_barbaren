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


//The username and password are checked here and send to the visitor

namespace Jaar_1_Project_4 {
    public sealed partial class StudentLogin : Page {
        private IClassicOption<string> username;
        private IClassicOption<string> password;
        private ArrayIterator<IClassicOption<string>> firstCheck; //Regardless if the object is some or none, it will be put in the list
        private ArrayIterator<IClassicOption<string>> secondCheck; //Only the some objects are in this list
        private IOptionVisitor<ArrayIterator<IClassicOption<string>>> visitor;
        public StudentLogin() {
            this.username = new NoneLogin<string>(); //has the username
            this.password = new NoneLogin<string>(); //Has the password
            this.firstCheck = new ArrayIterator<IClassicOption<string>>();
            this.secondCheck = new ArrayIterator<IClassicOption<string>>();
            this.InitializeComponent();      
        }
        private void usernameEntered(object sender, PointerRoutedEventArgs e) {
        }
        private void isEntered(object sender, KeyRoutedEventArgs e) {
            if (e.Key == VirtualKey.Enter) {
                if (UsernameTypeBox.Text.ToString().Length <= 0) {
                    Debug.WriteLine("The user hasn't entered anything an username");
                }
                else {
                    username = new SomeLogin<string>(UsernameTypeBox.Text.ToString());
                }
            }
        }
        private void passwordTypeBox_KeyDown(object sender, KeyRoutedEventArgs e) {
            if (e.Key == VirtualKey.Enter) {
                if (UsernameTypeBox.Text.ToString().Length <= 0) {
                    Debug.WriteLine("The user hasn't entered anything an password");

                }
                else {
                    password = new SomeLogin<string>(UsernameTypeBox.Text.ToString());
                }

            }
        }
        private void createButton_Click(object sender, RoutedEventArgs e) {
            //TODO send the username and password to the database
            firstCheck.Add(this.username);
            firstCheck.Add(this.password);
            this.firstCheck.Reset();
            while (this.firstCheck.Count()) {
                if (this.firstCheck.Iterate().LambdaVisit<bool>(() => false, _ => true)) { //Check if the object is a some
                    secondCheck.Add(firstCheck.GetCurrent()); //If the condition check is true, then it's a some object
                    //The some object is put in the secondCheck list
                }
                else {
                    Debug.WriteLine("We got a none object here!");
                    //TODO call the label factory to have the label: Enter correct login details, on the screen.
                }
                visitor.OnSome(this.secondCheck);
            }
            this.Frame.Navigate(typeof(MainMenu));

        }
        public IClassicOption<string> getUserName {
            get {
                return this.username;
            }
        }
        public IClassicOption<string> getPassword {
            get {
                return this.password;
            }
        }

        private void studentLoginBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(CreateAccount));
        }
    }
}