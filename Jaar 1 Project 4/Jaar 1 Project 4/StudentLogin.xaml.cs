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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentLogin : Page {
        //The username and password will be saved to store it in the database
        private IOption<string> username = new None<string>(); //has the username
        private IOption<string> password = new None<string>();
        public StudentLogin() {
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
                    username = new Some<string>(UsernameTypeBox.Text.ToString());

                }
            }
        }

        private void passwordTypeBox_KeyDown(object sender, KeyRoutedEventArgs e) {
            if (e.Key == VirtualKey.Enter) {
                if (UsernameTypeBox.Text.ToString().Length <= 0) {
                    Debug.WriteLine("The user hasn't entered anything an password");

                }
                else {
                    password = new Some<string>(UsernameTypeBox.Text.ToString());

                }

            }
        }

        private void createButton_Click(object sender, RoutedEventArgs e) {
            //TODO send the username and password to the database
            this.Frame.Navigate(typeof(MainMenu));

        }
        public IOption<string> getUserName {
            get {
                return this.username;
            }
        }
        public IOption<string> getPassword {
            get {
                return this.password;
            }
        }

        private void studentLoginBackButton_Click(object sender, RoutedEventArgs e) {

        }
    }
}