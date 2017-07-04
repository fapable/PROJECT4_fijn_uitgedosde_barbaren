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

//Main job is to display education information about Wijnhaven 61
//Wijnhaven 61 Education page

namespace Jaar_1_Project_4 {
 
    public sealed partial class Wijnhaven61Education : Page {
        EducationQueryHandler educationQueryHandler;
        public Wijnhaven61Education() {
            this.educationQueryHandler = new EducationQueryHandler(); //To store the last selected education button
            this.InitializeComponent();
        }
        //Goes back to the wijnhaven61 page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven61));
        }
        //Stores the selected education button and then goes to the info pop up page
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            EducationQueryHandler.Education = educationQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(InfoPopup)); //Goes to the popup page
        }
    }
}
