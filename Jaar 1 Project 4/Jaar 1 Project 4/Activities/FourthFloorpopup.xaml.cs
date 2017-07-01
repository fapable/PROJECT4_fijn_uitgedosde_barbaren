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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FourthFloorpopup : Page {
        public FourthFloorpopup() {
            this.InitializeComponent();
            this.MakeQueriesAndTextBlocks(); //Creates queries and textblocks
        }

        private void backButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FourthFloor));

        }
        //As soon as the Secondfloor pop up page is loaded, this method gets called
        //Queries get created an the textblocks get created
        public void MakeQueriesAndTextBlocks() {
            StaticActivityQueryMaker.MakeQueries(StaticActivityQueryMaker.ButtonName);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.OpleidingNaam, 1);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.ClassroomID, 2);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.EventName, 3);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.Description, 4);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.Duration, 5);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.StartTime, 6);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.EndTime, 7);
            StaticActivityQueryMaker.CreateTextBlock(FourthfloorpopupGrid, StaticActivityQueryMaker.ClassroomID, 8);
        }
    }
}
