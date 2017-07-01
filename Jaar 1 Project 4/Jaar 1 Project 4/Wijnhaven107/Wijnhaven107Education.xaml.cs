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
    public sealed partial class Wijnhaven107Education : Page {
        public Wijnhaven107Education() {
            this.InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Education));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107Communication));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107Informatica));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Wijnhaven107TechnicalInformatica));
        }
    }
}
