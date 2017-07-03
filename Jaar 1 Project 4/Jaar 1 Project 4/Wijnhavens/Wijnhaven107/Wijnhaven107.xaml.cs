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

//Wijnhaven 107 page

namespace Jaar_1_Project_4 {
    public sealed partial class Wijnhaven107 : Page {
        EducationQueryHandler educationQueryHandler;
        public Wijnhaven107() {
            this.InitializeComponent();
            this.educationQueryHandler = new EducationQueryHandler();
            educationQueryHandler.CurrentWijnhavenGetSet = EducationQueryHandler.CurrentWijnhaven.wijnhaven107;
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107Education));

        }
    }
}
