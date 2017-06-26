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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Activities : Page {
        public Activities() {
            this.InitializeComponent();
        }

        private void activitiesBackButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(OpenDagInformatie));
        }

        private void firstFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FirstFloor));
        }

        private void secondFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SecondFloor));
        }

        private void thirdFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ThirthFloor));
        }

        private void fourthFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FourthFloor));
        }

        private void fifthFloorButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(FifthFloor));
        }
    }
}
