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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FourthFloor : Page {
        public FourthFloor() {
            this.InitializeComponent();
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape; //Flips page
        }

        private void fourthFlourBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Activities));
        }

        private void classroomClick(object sender, RoutedEventArgs e) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the buttonname
            /*
            The foreach loop is here because you can't have buttonnames with dots
            Since the database tables need to match the buttonname, the foreach loop is made to change
            the buttoname          
           */
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") {
                    emptyButtonName += ".";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            Debug.WriteLine("Clicked on classroom... what is your name? My name is: " + emptyButtonName);
        }
    }
}
