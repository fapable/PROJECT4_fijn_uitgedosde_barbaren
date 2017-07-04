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

//Main job is to display info information on the screen
//All the info pages of the result of the different Wijnhaven pages  are shown on this page
//it is a dynamic page that changes on runtime based on the clicked info button 

namespace Jaar_1_Project_4 {
    public sealed partial class InfoPopup : Page, IPagePopup{
        StaticInfoQueryHandler infoQueryHandler; //To create the queries and display the text (query results) on the screen
        public InfoPopup() {
            this.infoQueryHandler = new StaticInfoQueryHandler();
            this.InitializeComponent();
            this.MakeQueriesAndTextBlocks();  //As soon as the page is loaded, the query results are drawn on it on runtime (dynamic)  
        }
        //Based on the last selected wijnhaven info page, the back button goes to that wijnhaven page
        //Enum is to track which wijnhaven was last clicked to know to which floor the application goes when the back button is clicked
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            switch (EducationQueryHandler.theCurrentWijnhaven) {
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven61:
                    this.Frame.Navigate(typeof(Wijnhaven61));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven99:
                    this.Frame.Navigate(typeof(Wijnhaven61));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven103:
                    this.Frame.Navigate(typeof(Wijnhaven103));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven107:
                    this.Frame.Navigate(typeof(Wijnhaven107));
                    break;
                default:
                    break;
            }

        }
        //Queries get created and the textblocks get created, in the textblocks the query result will appear
        public void MakeQueriesAndTextBlocks() {
            infoQueryHandler.MakeQueries(StaticInfoQueryHandler.Wijnhaven); //Creates queries, as argument is given the last clicked on eventroom button
            infoQueryHandler.SetTextOnScreen(infoPopupGrid);  //The text (query result) is displayed on the screen
            //As argument is given the grid (page) on which the query results should be drawn
        }
    }
}
