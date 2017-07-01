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
            //Queries are made, as argument is given the clicked on buttoname (the event classroom)
            StaticActivityQueryMaker.MakeQueries(StaticActivityQueryMaker.ButtonName);

            /* These methods below create a textblock for each column from the DB
            As arguments is given the grid where it's drawn on, and the text (the query result)
            but before an SQL query result is drawn on the screen, it first gets converted.
            Why? Because the result has brackets and other things that are not nice to read
            They are removed in that method and the method then returns a: "prettier" querry result to read,
            and as final argument is given in which row the textblock needs to drawn
            it is comparable to Excel where you have columns and rows
            */
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.OpleidingNaam), 1);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.ClassroomID), 2);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.EventName), 3);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.Description), 4);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.Duration), 5);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.StartTime), 6);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.EndTime), 7);
            StaticActivityQueryMaker.CreateTextBlock(secondFloorPopupGrid, StaticActivityQueryMaker.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.ClassroomID), 8);
        }
    }
}
