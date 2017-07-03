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



namespace Jaar_1_Project_4 {
 
    public sealed partial class Wijnhaven61Education : Page {
        EducationQueryHandler educationQueryHandler;
        public Wijnhaven61Education() {
            this.educationQueryHandler = new EducationQueryHandler();
            this.InitializeComponent();
        }

        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven61));
        }
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            EducationQueryHandler.Education = educationQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(InfoPopup)); //Goes to the popup page
        }
    }
}
