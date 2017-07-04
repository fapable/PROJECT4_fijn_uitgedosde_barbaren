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
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Diagnostics;

//Main job is to display activity (event) information on the screen
//All the floors pages (second floor and etc), the result of them are shown on this page
//it is a dynamic page that changes on runtime based on the clicked eventroom in one of the activity floor pages

namespace Jaar_1_Project_4 {
    public sealed partial class ActivityPopup : Page, IPagePopup {
        ActivityQueryHandler activityQueryHandler; //To create the queries and display the text (query results) on the screen
        public ActivityPopup() {        
            this.InitializeComponent();
            this.activityQueryHandler = new ActivityQueryHandler();
            MakeQueriesAndTextBlocks(); //As soon as the page is loaded, the query results are drawn on it on runtime (dynamic)  
        }
        //Based on the last selected floor page, the back button goes to that floor
        //Enum is to track which floor was last clicked to know to which floor the application goes when the back button is clicked
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            switch (ActivityQueryHandler.theCurrentFloor) {
                case ActivityQueryHandler.CurrentFloor.secondfloor:
                    this.Frame.Navigate(typeof(SecondFloor));
                    break;
                case ActivityQueryHandler.CurrentFloor.thirdfloor:
                    this.Frame.Navigate(typeof(ThirthFloor));
                    break;
                case ActivityQueryHandler.CurrentFloor.fourthfloor:
                    this.Frame.Navigate(typeof(FourthFloor));
                    break;
                default:
                    break;
            }
        }
        //Queries get created and the textblocks get created, in the textblocks the query result will appear
        public void MakeQueriesAndTextBlocks() {
            activityQueryHandler.MakeQueries(activityQueryHandler.ButtonName); //Creates queries, as argument is given the last clicked on eventroom button
            activityQueryHandler.SetTextOnScreen(ActivityPopupGrid); //The text (query result) is displayed on the screen
            //As argument is given the grid (page) on which the query results should be drawn
        }
    }
}
