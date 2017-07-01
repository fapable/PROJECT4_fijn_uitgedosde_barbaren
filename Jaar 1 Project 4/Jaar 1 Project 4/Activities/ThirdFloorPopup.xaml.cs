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
    public sealed partial class ThirdFloorPopup : Page {
        public ThirdFloorPopup() {
            this.InitializeComponent();
            this.MakeQueriesAndTextBlocks(); //Creates queries and textblocks
        }
        //As soon as the Secondfloor pop up page is loaded, this method gets called
        //Queries get created an the textblocks get created
        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ThirthFloor));
        }
        /* These methods below create a textblock for each column from the DB
        As arguments is given the grid where it's drawn on, and the text (the query result)
        but before an SQL query result is drawn on the screen, it first gets converted.
        Why? Because the result has brackets and other things that are not nice to read
        They are removed in that method and the method then returns a: "prettier" querry result to read,
        and as final argument is given in which row the textblock needs to drawn
        it is comparable to Excel where you have columns and rows
        */
        public void MakeQueriesAndTextBlocks() {
            StaticActivityQueryMaker.MakeQueries(StaticActivityQueryMaker.ButtonName);
            StaticActivityQueryMaker.SetTextOnScreen(thirdFloorPopupGrid);
        }
    }
}
