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

namespace Jaar_1_Project_4{
    public sealed partial class InfoPopup : Page, IPagePopup{
        StaticInfoQueryHandler infoQueryHandler;
        public InfoPopup() {
            this.infoQueryHandler = new StaticInfoQueryHandler();
            this.InitializeComponent();
            this.MakeQueriesAndTextBlocks();
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            switch (EducationQueryHandler.theCurrentWijnhaven) {
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven61:
                    this.Frame.Navigate(typeof(Wijnhaven61));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven99:
                    this.Frame.Navigate(typeof(Wijnhaven61));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven103:
                    this.Frame.Navigate(typeof(Wijnhaven103));
                    break;
                case EducationQueryHandler.CurrentWijnhaven.wijnhaven107:
                    this.Frame.Navigate(typeof(Wijnhaven107));
                    break;
                default:
                    break;
            }

        }
        public void MakeQueriesAndTextBlocks() {
            infoQueryHandler.MakeQueries(StaticInfoQueryHandler.Wijnhaven);
            infoQueryHandler.SetTextOnScreen(infoPopupGrid);
        }
    }
}
