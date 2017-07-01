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
using Windows.Graphics.Display; //For the flip
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;


namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondFloor : Page {
        public SecondFloor() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape; //Flips page
        }
        private void secondFlourBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }
        //When an event classroom gets clicked, the clicked on event classroom comes into this method
        //Then it it set to the StaticActivityQueryMaker class to create queries based on it
        private void classroomClick(object sender, RoutedEventArgs e) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the converted buttonname
            /*
            The foreach loop is here because you can't have object names with dots in UWP
            Since the database tables need to match the buttonname, the foreach loop is made to change (convert)
            the buttoname to match the DB tables
             */
            foreach (var letter in clickedOnButton.Name.ToString()) {            
                if (letter.ToString() == "_") {
                    emptyButtonName += ".";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            StaticActivityQueryMaker.ButtonName = emptyButtonName; //Buttoname gets SET so it can reached within SecondFloorPopup class
            this.Frame.Navigate(typeof(SecondFloorPopup)); //Goes to the popup page
        }
    }
}