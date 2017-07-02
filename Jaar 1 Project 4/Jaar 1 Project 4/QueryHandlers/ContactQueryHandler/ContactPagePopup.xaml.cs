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

//The contact page pop up, on this page the contact information gets loaded

namespace Jaar_1_Project_4 {
    public sealed partial class ContactPagePopup : Page, IPagePopup {
        ContactQueryHandler contactQueryHandler;
        public ContactPagePopup() {
            this.InitializeComponent();
            this.contactQueryHandler = new ContactQueryHandler();
            this.MakeQueriesAndTextBlocks();
        }
        public void MakeQueriesAndTextBlocks() {
            contactQueryHandler.MakeQueries(ContactQueryHandler.CurrentChoice);
            contactQueryHandler.SetTextOnScreen(contactPopupGrid);
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ContactPage));
        }
    }
}
