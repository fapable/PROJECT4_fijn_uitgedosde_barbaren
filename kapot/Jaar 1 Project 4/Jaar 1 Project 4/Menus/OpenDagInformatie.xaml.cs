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
    public sealed partial class OpenDagInformatie : Page {
        public OpenDagInformatie() {
            this.InitializeComponent();
        }

        private void openDayBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void activitiesButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }

        private void educationButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Education));
        }

        private void locationsButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(WijnhavenLocations));

        }
        private void contactButton_click(System.Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ContactPage));


        }


    }
}
