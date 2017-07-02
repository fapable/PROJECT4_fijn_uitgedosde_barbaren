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

//Openday information page

namespace Jaar_1_Project_4 {

    public sealed partial class OpenDagInformatie : Page {
        public OpenDagInformatie() {
            this.InitializeComponent();
        }
        //Goes to the main menu
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainMenu));
        }
        //Goes to the activities page
        private void ActivitiesButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }
        //Goes to the Wijnhaven 107 page
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107));
        }
        //Goes to the  wijnhaven locations page
        private void LocationsButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(WijnhavenLocations));
        }
        //Goes to the contact page
        private void ContactButtonClick(System.Object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ContactPage));


        }


    }
}
