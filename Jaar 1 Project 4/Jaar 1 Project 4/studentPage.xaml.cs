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
    public sealed partial class studentPage : Page {
        public studentPage() {
            this.InitializeComponent();
        }
        private void BackClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
           


        }

        private void studenloginButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(StudentLogin));
        }
    }
}
