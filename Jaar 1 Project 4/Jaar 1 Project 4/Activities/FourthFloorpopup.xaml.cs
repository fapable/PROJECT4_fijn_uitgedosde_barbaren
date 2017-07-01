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

namespace Jaar_1_Project_4 {

    public sealed partial class FourthFloorpopup : Page {
        public FourthFloorpopup() {
            this.InitializeComponent();
            this.MakeQueriesAndTextBlocks(); //Creates the queries and textblocks (results)
        }
        private void backButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FourthFloor));
        }
        //As soon as the Secondfloor pop up page is loaded, this method gets called
        //Queries get created an the textblocks get created
        public void MakeQueriesAndTextBlocks() {
            //Queries are made, as argument is given the clicked on buttoname (the event classroom)
            StaticActivityQueryMaker.MakeQueries(StaticActivityQueryMaker.ButtonName);

            StaticActivityQueryMaker.SetTextOnScreen(FourthfloorpopupGrid);
        }
    }
}
