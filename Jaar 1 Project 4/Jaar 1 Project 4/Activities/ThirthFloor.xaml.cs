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
using System.Diagnostics;

namespace Jaar_1_Project_4 {
    public sealed partial class ThirthFloor : Page {
        public ThirthFloor() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape; //Flips page (for mobile0
        }
        private void BackButton(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }
        //When an event classroom gets clicked, the clicked on event classroom comes into this method
        //Then it it set to the StaticActivityQueryMaker class to create queries based on it
        private void classroomClick(object sender, RoutedEventArgs e) {
            StaticActivityQueryMaker.ButtonName = AbstractGeneralQueryHandler.ChangeMainStaticAttributeName(sender);
            this.Frame.Navigate(typeof(ThirdFloorPopup)); //Goes to the popup page           
        }
    }
}
