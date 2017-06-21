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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WijnhavenLocations : Page {
        public WijnhavenLocations() {
            this.InitializeComponent();
        }

        private void wijnhaven61Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven61));
        }

        private void wijnhaven99Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven99));
        }

        private void wijnhaven103Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven103));
        }
    }
}
