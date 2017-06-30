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
using Jaar_1_Project_4_Messages;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Jaar_1_Project_4.QuestionSystem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QandAPage : Page
    {
        public QandAPage()
        {
            this.InitializeComponent();
            //foreach result in query return add to de lijst?
            Grid current_page = qanda;
            string[] qena = new string[8];
            qena[0] = "Is het mogelijk om voor rolstoel gangers alle gebouwen te betreden, dit in verband met mijn gehandicapte dochter ofzo, lol dit is een kut verhaal ff kijken of shit past jwz";
            qena[1] = "antwoord";
            qena[2] = "vraag 2";
            qena[3] = "antwoord 2";
            qena[4] = "vraag 3";
            qena[5] = "antwoord 3";
            qena[6] = "vraag 4";
            qena[7] = "antwoord 4";
            int basex = -360;
            int basey = -420;
            int basewidth = 640;
            int baseheieght = 80;
            for(int current = 0; current < qena.Count(); current++)
            {
                if(current % 2 == 0)
                {
                    Message current_message = MessageFactory.Create(MessageType.question, new EasyLabel(basex, (basey + (130 * current)), basewidth, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 100 * current);
                    current_message.Draw();
                }
                else if(current % 2 != 0)
                {
                    Message current_message = MessageFactory.Create(MessageType.answer, new EasyLabel(basex, (basey + (130 * current)), basewidth, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 100 * current);
                    current_message.Draw();
                }
            }
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mainQpage));
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
        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }
    }
}
