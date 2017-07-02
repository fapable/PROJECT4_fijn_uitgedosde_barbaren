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
    public sealed partial class Wijnhaven99Education : Page {
        EducationQueryHandler educationQueryHandler;
        public Wijnhaven99Education() {
            this.InitializeComponent();
            this.educationQueryHandler = new EducationQueryHandler();

        }
        private void back_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven99));
        }
        private void EducationButtonClick(object sender, RoutedEventArgs e) {
            EducationQueryHandler.Education = educationQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(EducationPagePopUp)); //Goes to the popup page
        }   
    }
}
