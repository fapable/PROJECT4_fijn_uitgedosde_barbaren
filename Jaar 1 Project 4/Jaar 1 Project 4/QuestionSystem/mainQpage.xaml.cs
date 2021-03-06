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
using Windows.Graphics.Display; //For the mobile flip


namespace Jaar_1_Project_4.QuestionSystem {
    public sealed partial class mainQpage : Page {
        public mainQpage() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait; //flips screen (for mobile only)
        }
        private void AskAQuestion(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Questions)); //change current page to the ask a question page
        }
        private void ToQandAButton(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(QandAPage)); //change current page to general q and a page
        }
        private void backButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainMenu)); //change current page to the main menu
        }
    }
}
