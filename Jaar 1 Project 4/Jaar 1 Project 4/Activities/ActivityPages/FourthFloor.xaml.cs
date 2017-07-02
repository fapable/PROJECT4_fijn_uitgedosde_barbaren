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

//The fourth floor page

namespace Jaar_1_Project_4 {
    public sealed partial class FourthFloor : Page {
        ActivityQueryHandler activityQueryHandler; //To change enum and to set the name of the clicked event room
        public FourthFloor() {
            this.InitializeComponent();
            this.activityQueryHandler = new ActivityQueryHandler();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape; //Rotates screen (only for mobile)
            activityQueryHandler.CurrentFloorGetSet = ActivityQueryHandler.CurrentFloor.fourthfloor; //Changes enum to keep track of the current selected floor    
        }
        //Goes the activities page
        private void fourthFlourBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }
        //When an eventroom gets clicked, the clicked on event room objects comes into this method
        //Then it it set to the attribute of the  StaticActivityQueryMaker class to create queries based on it
        private void EventRoomClick(object sender, RoutedEventArgs e) {
            activityQueryHandler.ButtonName = activityQueryHandler.ChangeMainAttributeName(sender); //Name first get converted and then set
            this.Frame.Navigate(typeof(ActivityPopup)); //Goes to the popup page
        }
    }
}
