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
    public sealed partial class ThirdFloorPopup : Page {
        public ThirdFloorPopup() {
            this.InitializeComponent();
            this.MakeQueriesAndTextBlocks(); //Creates queries and textblocks
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ThirthFloor));
        }
        //As soon as the Secondfloor pop up page is loaded, this method gets called
        //Queries get created an the textblocks get created
        public void MakeQueriesAndTextBlocks() {
            StaticActivityQueryMaker.MakeQueries(StaticActivityQueryMaker.ButtonName);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.OpleidingNaam, 1);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.ClassroomID, 2);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.EventName, 3);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.Description, 4);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.Duration, 5);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.StartTime, 6);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.EndTime, 7);
            StaticActivityQueryMaker.CreateTextBlock(thirdFloorPopupGrid, StaticActivityQueryMaker.ClassroomID, 8);
        }
    }
}
