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

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateAccount : Page {
        public CreateAccount() {
            this.InitializeComponent();
        }
        private void createAccountButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(StudentLogin));
        }
        private void back_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(StudentLogin));
        }
    }
}
