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

//Mainjob is to give the option to go to the wijnhaven 61 education page
//Wijnhaven 61 page

namespace Jaar_1_Project_4 {
    public sealed partial class Wijnhaven61 : Page {
        EducationQueryHandler educationQueryHandler;  //Is made to have the enum set to the last clicked wijnhaven
        StaticInfoQueryHandler infoQueryHandler; //to store the button name and then make queries based on it
        public Wijnhaven61() {
            this.InitializeComponent();
            this.educationQueryHandler = new EducationQueryHandler();
            this.infoQueryHandler = new StaticInfoQueryHandler();
            educationQueryHandler.CurrentWijnhavenGetSet = EducationQueryHandler.CurrentWijnhaven.wijnhaven61;  //Changes state to keep track of the last selected wijnhaven
        }
        //Goes to the wijnhaven 61 education page
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven61Education));
        }
        //Goes to the wijnhaven locations page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(WijnhavenLocations));
        }
        //Stores the clicked on button and then goes to the popup page
        private void InfoClickButton(object sender, RoutedEventArgs e) {
            StaticInfoQueryHandler.Wijnhaven = infoQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(InfoPopup)); //Goes to the popup page
        }
    }
}
