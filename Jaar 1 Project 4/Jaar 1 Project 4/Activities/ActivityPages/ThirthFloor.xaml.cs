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
using Windows.Graphics.Display;
using System.Diagnostics;

//The thirth floor page
//The main job of the thirth floor page is to show openday events related to the thirth floor of the school

namespace Jaar_1_Project_4 {
    public sealed partial class ThirthFloor : Page {
        //Object is used to change his enum attribute to keep track of the selected school floor
        //Based on the state of the enum, the back button (in the activity pop up page) goes to a certain wijnhaven school page
        ActivityQueryHandler activityQueryHandler;
        public ThirthFloor() {
            this.InitializeComponent();
            this.activityQueryHandler = new ActivityQueryHandler(); //to store button name
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape;  //Rotates screen (only for mobile)
            activityQueryHandler.CurrentFloorGetSet = ActivityQueryHandler.CurrentFloor.thirdfloor;  //Changes enum to keep track of the current selected floor    
        }
        //Goes the activities page
        private void ThirthFloorBackButton(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }
        //The eventrooms are buttons in the application, so the button name (when its clicked) comes into this method
        //Then the name of the button is set to an attribute of the activityqueryhandler class to create queries based on it.
        private void ClassroomClick(object sender, RoutedEventArgs e) {
            //The name of the button gets first converted, because it is illigal to have dots in an object name
            //But since the classroom are written as dots in the Database, the objectname gets converted to match the database attributes
            activityQueryHandler.ButtonName = activityQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(ActivityPopup));           
        }
    }
}
