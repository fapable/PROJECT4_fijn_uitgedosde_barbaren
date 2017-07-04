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

//Main job is to display education information about Wijnhaven 107
//Wijnhaven 107 Education page

namespace Jaar_1_Project_4 {
    public sealed partial class Wijnhaven107Education : Page {
        EducationQueryHandler educationQueryHandler;
        public Wijnhaven107Education() {
            this.educationQueryHandler = new EducationQueryHandler(); //To store the last selected education button
            this.InitializeComponent();
        }
        //Stores the selected education button and then goes to the education pop up page
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            EducationQueryHandler.Education = educationQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(EducationPagePopUp)); //Goes to the popup page
        }
        //Goes back to the wijnhaven 107 page
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107));

        }
    }
}
