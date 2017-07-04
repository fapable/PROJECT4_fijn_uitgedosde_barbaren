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

//Mainjob is to give the option to go to the wijnhaven 9 education page
//Wijnhaven 99 page

namespace Jaar_1_Project_4 {
    public sealed partial class Wijnhaven99 : Page {
        EducationQueryHandler educationQueryHandler; //Is made to have the enum set to the last clicked wijnhaven
        StaticInfoQueryHandler infoQueryHandler; //to store the button name and then make queries based on it
        public Wijnhaven99() {
            this.InitializeComponent();
            educationQueryHandler = new EducationQueryHandler();
            this.infoQueryHandler = new StaticInfoQueryHandler();
            educationQueryHandler.CurrentWijnhavenGetSet = EducationQueryHandler.CurrentWijnhaven.wijnhaven99; //Changes state to keep track of the last selected wijnhaven
        }
        //Goes to the education page
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven99Education));
        }
        //Goes back to the wijnhavenslocation page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(WijnhavenLocations));
        }
        //Stores the clicked on button and then goes to the popup page
        private void InfoClickButton(object sender, RoutedEventArgs e) {
            StaticInfoQueryHandler.Wijnhaven = this.infoQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(InfoPopup)); //Goes to the popup page
        }
    }
}
