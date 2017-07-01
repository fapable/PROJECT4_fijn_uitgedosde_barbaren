﻿using System;
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



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

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

        private void classroomClick(object sender, RoutedEventArgs e) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the buttonname
                /*
                The foreach loop is here because you can't have buttonnames with dots
                Since the database tables need to match the buttonname, the foreach loop is made to change
                the buttoname with lower: _ , to buttoname with dots.          
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