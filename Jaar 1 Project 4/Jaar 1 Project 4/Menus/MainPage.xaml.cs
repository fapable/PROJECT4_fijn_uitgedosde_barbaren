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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Jaar_1_Project_4
{
    public sealed partial class MainPage : Page {
        public MainPage()
        {
            this.InitializeComponent();
        
            
        }
        //Button click for the student button
        private void studentLoginClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(StudentLogin));
     
        }
        //Button click for the Exit button
        private void ExitClick(object sender, RoutedEventArgs e) {
            Application.Current.Exit();

        }
        //Button click for the teacher button
        private void teacherLoginClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(TeacherLogIn));

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
