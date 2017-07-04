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
using System.Net.Http;
using Jaar_1_Project_4_Messages;

namespace Jaar_1_Project_4 {
    public sealed partial class Answer : Page {
        public Answer() {
            this.InitializeComponent();
            //question.Draw();
        }

        private void mainTitle_SelectionChanged(object sender, RoutedEventArgs e) {

        }

        private void BackButtonClick(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void send_message(object sender, RoutedEventArgs e) {
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {

          

        }

        private int getWidth()
        {
            FrameworkElement pnlClient = this.Content as FrameworkElement;
            if (pnlClient != null)
            {
                double Width = pnlClient.ActualWidth;
                return (int)Width;
            }
            return 0;
        }
        private int getHeight()
        {
            FrameworkElement pnlClient = this.Content as FrameworkElement;
            if (pnlClient != null)
            {
                double height = pnlClient.ActualHeight;
                return (int)Height;
            }
            return 0;
        }
    }
}
