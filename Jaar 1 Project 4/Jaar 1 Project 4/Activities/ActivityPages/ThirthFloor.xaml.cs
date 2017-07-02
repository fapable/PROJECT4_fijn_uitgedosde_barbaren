﻿using System;
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
//Read the comments from fourthfloor page

namespace Jaar_1_Project_4 {
    public sealed partial class ThirthFloor : Page {
        ActivityQueryHandler activityQueryHandler;
        public ThirthFloor() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape; 
            this.activityQueryHandler = new ActivityQueryHandler();
            activityQueryHandler.CurrentFloorGetSet = ActivityQueryHandler.CurrentFloor.thirdfloor;
        }
        private void ThirthFloorBackButton(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }
        private void classroomClick(object sender, RoutedEventArgs e) {
            activityQueryHandler.ButtonName = activityQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(ActivityPopup));           
        }
    }
}
