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

//On this page all education related things get drawn on

namespace Jaar_1_Project_4 {
    public sealed partial class EducationPagePopUp : Page, IPagePopup {
        EducationQueryHandler educationQueryHandler;
        public EducationPagePopUp() {
            this.InitializeComponent();
            this.educationQueryHandler = new EducationQueryHandler();
            MakeQueriesAndTextBlocks();
        }
        private void BackButtonClick(object sender, RoutedEventArgs e) {
            switch (EducationQueryHandler.theCurrentWijnhaven) {
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven61:
                    this.Frame.Navigate(typeof(Wijnhaven61Education));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven99:
                    this.Frame.Navigate(typeof(Wijnhaven99Education));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven103:
                    this.Frame.Navigate(typeof(Wijnhaven103));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven107:
                    this.Frame.Navigate(typeof(Wijnhaven107Education));
                    break;
                default:
                    break;
            }
        }
        public void MakeQueriesAndTextBlocks() {
            educationQueryHandler.MakeQueries(EducationQueryHandler.Education);
            educationQueryHandler.SetTextOnScreen(wijnhavenEducationpopup);
        }
    }
}
