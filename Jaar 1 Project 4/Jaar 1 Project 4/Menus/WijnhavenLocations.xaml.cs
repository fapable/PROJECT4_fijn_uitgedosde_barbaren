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

//The wijnhavens location page

namespace Jaar_1_Project_4 {
    public sealed partial class WijnhavenLocations : Page {
        public WijnhavenLocations() {
            this.InitializeComponent();
        }
        //Goes to the wijnhaven 61 page
        private void Wijnhaven61ButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven61));
        }
        //Goes to the wijnhaven 99 page
        private void Wijnhaven99ButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven99));
        }
        //Goes to the wijnhaven 103 page
        private void Wijnhaven103ButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven103));
        }
        //Goes to the opendaginformation page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));

        }
    }
}
