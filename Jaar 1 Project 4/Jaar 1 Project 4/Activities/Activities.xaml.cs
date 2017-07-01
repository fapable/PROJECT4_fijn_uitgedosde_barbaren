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

namespace Jaar_1_Project_4 {
    public sealed partial class Activities : Page {
        public Activities() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait; //flips screen (for mobile only)
        }
        private void activitiesBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie)); //Changes page
        }
        private void secondFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SecondFloor));
        }
        private void thirdFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ThirthFloor));
        }
        private void fourthFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FourthFloor));
        }
    }
}
