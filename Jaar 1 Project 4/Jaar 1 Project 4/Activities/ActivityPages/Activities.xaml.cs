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
using Windows.Graphics.Display; //For the mobile flip

//The Activity Main Page

namespace Jaar_1_Project_4 {
    public sealed partial class Activities : Page {
        public Activities() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait; //flips screen (for mobile only)
        }
        //Goes back to the menu: Opendaginformatie
        private void ActivitiesBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie)); //frame.navigate changes the page
        }
        //Goes to the seconfloor page
        private void SecondFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SecondFloor)); 
        }
        //Goes to the thirthfloor page
        private void ThirdFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ThirthFloor));
        }
        //Goes to the fourthfloor page
        private void FourthFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FourthFloor));
        }
    }
}
