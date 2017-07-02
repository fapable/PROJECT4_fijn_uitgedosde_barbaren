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

//The contact page

namespace Jaar_1_Project_4 {
    public sealed partial class ContactPage : Page {
        ContactQueryHandler contactQueryHandler;
        public ContactPage()
        {
            this.InitializeComponent();
            this.contactQueryHandler = new ContactQueryHandler();
        }

        private void BackButtonclick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }

        private void StudyChoiceClick(object sender, RoutedEventArgs e) {        
            ContactQueryHandler.CurrentChoice = contactQueryHandler.ChangeMainAttributeName(sender);
            this.Frame.Navigate(typeof(ContactPagePopup)); //Goes to the popup page      
        }
    }
}
