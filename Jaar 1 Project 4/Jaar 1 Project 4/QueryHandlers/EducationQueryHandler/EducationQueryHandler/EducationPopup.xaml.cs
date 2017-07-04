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

//Main job is to display education information on the screen
//All the different eduction pages from the different wijnhaven schools, the result of them are shown on this page
//it is a dynamic page that changes on runtime based on the clicked education button 

namespace Jaar_1_Project_4 {
    public sealed partial class EducationPagePopUp : Page, IPagePopup {
        EducationQueryHandler educationQueryHandler; //To create the queries and display the text (query results) on the screen
        public EducationPagePopUp() {
            this.InitializeComponent();
            this.educationQueryHandler = new EducationQueryHandler();
            MakeQueriesAndTextBlocks();  //As soon as the page is loaded, the query results are drawn on it on runtime (dynamic)  
        }
        //Based on the current selected wijnhaven, the back button goes to that wijnhaven
        //Enum is to track which floor was last clicked to know to which floor the application goes when the back button is clicked
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            switch (EducationQueryHandler.theCurrentWijnhaven) {
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven61:
                    this.Frame.Navigate(typeof(Wijnhaven61Education));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven99:
                    this.Frame.Navigate(typeof(Wijnhaven99Education));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven103:
                    this.Frame.Navigate(typeof(Wijnhaven103));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven107:
                    this.Frame.Navigate(typeof(Wijnhaven107Education));
                    break;
                default:
                    break;
            }
        }
        //Queries get created and the textblocks get created, in the textblocks the query result will appear
        public void MakeQueriesAndTextBlocks() {
            educationQueryHandler.MakeQueries(EducationQueryHandler.Education); //Creates queries, as argument is given the last clicked on eventroom button
            educationQueryHandler.SetTextOnScreen(wijnhavenEducationpopup); //The text (query result) is displayed on the screen
             //As argument is given the grid (page) on which the query results should be drawn
        }
    }
}
