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

//The main menu (first page of the whole application)

namespace Jaar_1_Project_4 {
    public sealed partial class MainMenu : Page {
        public MainMenu() {
            this.InitializeComponent();      
        }
        //Exits the application
        private void ExitButtonClick(object sender, RoutedEventArgs e) {
            Application.Current.Exit();
        }
        //Goes to the opendaginformation page
        private void OpenDagInformationClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }
        //Goes the login page
        private void MainLoginPageClick(object sender, RoutedEventArgs e) {
            if(DatabaseLoginCheck.IsTeacherLoggedIn == true) {
                this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.QandAPage));
            }
            else {
                this.Frame.Navigate(typeof(MainLoginPage));
            }
            
        }
        //Goes to the help page
        private void HelpPageClick(object sender, RoutedEventArgs e){
            this.Frame.Navigate(typeof(HelpPage));
        }
    }
}

