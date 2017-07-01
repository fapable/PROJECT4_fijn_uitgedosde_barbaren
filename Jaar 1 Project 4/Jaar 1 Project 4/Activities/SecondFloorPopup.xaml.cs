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


namespace Jaar_1_Project_4 {

    public sealed partial class SecondFloorPopup : Page {
        public SecondFloorPopup() {
            this.InitializeComponent();
            MakeQueriesAndTextBlocks(); //Creaties queries and textblocks       
        }
        //When the click me button is clicked, the query gets craeted
        private void backButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SecondFloor));
        }
        //As soon as the Secondfloor pop up page is loaded, this method gets called
        //Queries get created an the textblocks get created
        public void MakeQueriesAndTextBlocks() {
            StaticActivityQueryMaker.MakeQueries(StaticActivityQueryMaker.ButtonName);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.OpleidingNaam, 1);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ClassroomID, 2);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.EventName, 3);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.Description, 4);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.Duration, 5);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.StartTime, 6);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.EndTime, 7);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ClassroomID, 8);
        }
    }
}
