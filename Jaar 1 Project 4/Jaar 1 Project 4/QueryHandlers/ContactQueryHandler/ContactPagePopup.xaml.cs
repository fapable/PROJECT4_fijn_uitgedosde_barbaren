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

//Main job is to display contact information on the screen
//All the different type of contact information, the result of them are shown on this page
//it is a dynamic page that changes on runtime based on the clicked contact button

namespace Jaar_1_Project_4 {
    public sealed partial class ContactPagePopup : Page, IPagePopup {
        ContactQueryHandler contactQueryHandler;  //To create the queries and display the text (query results) on the screen
        public ContactPagePopup() {
            this.InitializeComponent();
            this.contactQueryHandler = new ContactQueryHandler();
            this.MakeQueriesAndTextBlocks();  //As soon as the page is loaded, the query results are drawn on it on runtime (dynamic)  
        }
        //Queries get created and the textblocks get created, in the textblocks the query result will appear
        public void MakeQueriesAndTextBlocks() {
            contactQueryHandler.MakeQueries(ContactQueryHandler.CurrentChoice);  //Creates queries, as argument is given the last clicked on contact button
            contactQueryHandler.SetTextOnScreen(contactPopupGrid); //The text (query result) is displayed on the screen
               //As argument is given the grid (page) on which the query results should be drawn
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ContactPage));
        }
    }
}
