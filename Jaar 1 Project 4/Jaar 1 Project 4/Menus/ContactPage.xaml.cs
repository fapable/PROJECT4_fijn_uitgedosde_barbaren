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

//Main job of the contact page is that it displays the general contact information of the hogeschool rotterdam

namespace Jaar_1_Project_4 {
    public sealed partial class ContactPage : Page {
        ContactQueryHandler contactQueryHandler;
        public ContactPage() {
            this.InitializeComponent();
            this.contactQueryHandler = new ContactQueryHandler();
        }
        //Goes back the opendag informatie page
        private void BackButtonclick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }
        //Stores the clicked on contact button and then stores it.
        //It is stored because based on the clicked on button, queries gets made 
        //the paramter: sender, is the clicked on button
        private void StudyChoiceClick(object sender, RoutedEventArgs e) {        
            ContactQueryHandler.CurrentChoice = contactQueryHandler.ChangeMainAttributeName(sender); //Stores the clicked on button
            this.Frame.Navigate(typeof(ContactPagePopup)); //Goes to the popup page      
        }
    }
}
