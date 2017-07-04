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

//Main job is to give fast access to functions in the application
//The main menu

namespace Jaar_1_Project_4 {
    public sealed partial class MainMenu : Page {
        public MainMenu() {
            this.InitializeComponent();      
        }
        //When exit button is clicked this method gets called, it exits the application
        private void ExitButtonClick(object sender, RoutedEventArgs e) {
            Application.Current.Exit();
        }
        //Goes to the opendaginformation page
        private void OpenDagInformationClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }
        //job is to see if the teacher is logged in, if the teacher is logged in then it skips the login page
        private void MainLoginPageClick(object sender, RoutedEventArgs e) {
            if(DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter == true) { //Checks if teacher is already logged in
                this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.QandAPage)); //goes to answer page if teacher is already logged in
            }
            else {
                this.Frame.Navigate(typeof(MainLoginPage)); //When teacher is not logged in it goes to the login page
            }            
        }
        //Goes to the help page
        private void HelpPageClick(object sender, RoutedEventArgs e){
            this.Frame.Navigate(typeof(HelpPage));
        }
    }
}

