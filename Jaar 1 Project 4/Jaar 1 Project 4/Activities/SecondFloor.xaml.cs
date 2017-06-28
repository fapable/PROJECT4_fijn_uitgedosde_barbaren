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
using System.Diagnostics; //To allow debug.writeline (no console writeline available)

//TODO give buttons name that matches the table name classroom

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

        private void send(object sender, RoutedEventArgs e) {

        }
        //Query's get send from this method. The classroom buttons share this same method
        //The button comes in this method (sender), and then the query gets made
        private void SendQuery(object sender, RoutedEventArgs e) {
            Button button = (Button) sender; //sender gets cast to button
            string emptyButtonName = ""; //buttonname will be saved in this
            foreach (var character in button.Name.ToString()) { //buttonname gets looped
                if (character.ToString() == "_") {
                    emptyButtonName += ".";
                }
                else {
                    emptyButtonName += character.ToString();
                }           
            }
            Debug.WriteLine("Button, what is your name? My name is: " + emptyButtonName);
        }
    }
}
