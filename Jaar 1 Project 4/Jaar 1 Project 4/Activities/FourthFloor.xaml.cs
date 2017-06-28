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
        //When a button(classroom) gets clicked, this method gets activated
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
            this.CreatePopUp();
            Debug.WriteLine("Button, what is your name? My name is: " + emptyButtonName);
        }
        //Creates the pop up that will appear on the screen
        //NOT DONE
        public void CreatePopUp() {
            Border popupBorder = new Border();
            
            Thickness thickness = new Thickness(123, 45, 0, 10);
            popupBorder.Margin = thickness;

            fourth_floor.Children.Add(popupBorder);
        }
    }
}
