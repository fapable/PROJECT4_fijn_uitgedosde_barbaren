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

//This page gets loaded when an event (class) from any of the floors are clicked

namespace Jaar_1_Project_4 {
    public sealed partial class ActivityPopup : Page, IPagePopup {
        ActivityQueryHandler activityQueryHandler;
        public ActivityPopup() {        
            this.InitializeComponent();
            this.activityQueryHandler = new ActivityQueryHandler();
            MakeQueriesAndTextBlocks(); //Creaties queries and textblocks       
        }
        //Based on the current floor, the back button goes to that floor
        //Enum is to track which floor is clicked
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
        //Queries get created and the textblocks get created
        public void MakeQueriesAndTextBlocks() {
            activityQueryHandler.MakeQueries(activityQueryHandler.ButtonName);
            activityQueryHandler.SetTextOnScreen(ActivityPopupGrid);
        }
    }
}
