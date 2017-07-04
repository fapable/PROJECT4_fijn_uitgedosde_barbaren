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

//Main job is to display the main login page

namespace Jaar_1_Project_4 {
    public sealed partial class MainLoginPage : Page {
        public MainLoginPage() {
            this.InitializeComponent();           
        }
        //Goes to the teacher login page 
        private void TeacherLoginClick(object sender, RoutedEventArgs e) {
                this.Frame.Navigate(typeof(TeacherLogIn));                     
        }
        //Goes back to the menu
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainMenu));
        }
        //Goes to the Q&A page
        private void StudentLoginClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }
    }
}
