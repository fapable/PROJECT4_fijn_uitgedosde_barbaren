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

//Main job is to show the help page

namespace Jaar_1_Project_4 {
    public sealed partial class HelpPage : Page {
        public HelpPage() {
            this.InitializeComponent();
        }
        //Goes to the menu page
        private void BackButtonClick(object sender, RoutedEventArgs e){
            this.Frame.Navigate(typeof(MainMenu));
        }
    }
}
