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

//Wijnhaven 103 page

namespace Jaar_1_Project_4 {
    public sealed partial class Wijnhaven103 : Page {
        EducationQueryHandler educationQueryHandler;
        StaticInfoQueryHandler infoQueryHandler;
        public Wijnhaven103() {
            this.InitializeComponent();
            this.educationQueryHandler = new EducationQueryHandler();
            this.infoQueryHandler = new StaticInfoQueryHandler();
            educationQueryHandler.CurrentWijnhavenGetSet = EducationQueryHandler.CurrentWijnhaven.wijnhaven103; //Changes state to keep track of the wijnhavne
        }
        //Goes to the wijnhavenlocations
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(WijnhavenLocations));
        }

        private void infoClickButton(object sender, RoutedEventArgs e) {
            StaticInfoQueryHandler.Wijnhaven = infoQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(InfoPopup)); //Goes to the popup page
        }
    }
}
