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

//Mainjob is to give the option to go to the wijnhaven 103 education and info page
//Wijnhaven 107 page

namespace Jaar_1_Project_4 {
    public sealed partial class Wijnhaven107 : Page {
        EducationQueryHandler educationQueryHandler; //Is made to have the enum set to the last clicked wijnhaven
        StaticInfoQueryHandler infoQueryHandler; //to store the button name and then make queries based on it
        public Wijnhaven107() {
            this.InitializeComponent();
            this.infoQueryHandler = new StaticInfoQueryHandler();
            this.educationQueryHandler = new EducationQueryHandler();
            educationQueryHandler.CurrentWijnhavenGetSet = EducationQueryHandler.CurrentWijnhaven.wijnhaven107; //Changes state to keep track of the last selected wijnhaven
        }
        //Goes back to the opendagInformatie page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }
        //Goes to the education page
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107Education));
        }
        //stores the selected button and then goes to the info pop up page
        private void InfoClickButton(object sender, RoutedEventArgs e) {
            StaticInfoQueryHandler.Wijnhaven = infoQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(InfoPopup)); //Goes to the popup page
        }
    }
}
