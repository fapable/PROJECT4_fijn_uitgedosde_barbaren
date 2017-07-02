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

//Wijnhaven 107 Education page

namespace Jaar_1_Project_4 {

    public sealed partial class Wijnhaven107Education : Page {
        EducationQueryHandler educationQueryHandler;
        public Wijnhaven107Education() {
            this.educationQueryHandler = new EducationQueryHandler();
            this.InitializeComponent();
        }
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            EducationQueryHandler.Education = educationQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(EducationPagePopUp)); //Goes to the popup page
        }

        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));

        }
    }
}
