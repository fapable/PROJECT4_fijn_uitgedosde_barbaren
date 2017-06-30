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
            string[] qena = new string[4];
            qena[0] = "vraag";
            qena[1] = "antwoord";
            qena[2] = "vraag 2";
            qena[3] = "antwoord 2";
            int basex = -200;
            int basey = -330;
            int basewidth = 320;
            int baseheieght = 140;
            for(int current = 0; current < qena.Count(); current++)
            {
                if(current % 2 == 0)
                {
                    Message current_message = MessageFactory.Create(MessageType.question, new EasyLabel(basex, (basey + (210 * current)), basewidth, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 180 * current);
                    current_message.Draw();
                }
                else if(current % 2 != 0)
                {
                    Message current_message = MessageFactory.Create(MessageType.answer, new EasyLabel(basex, (basey + (210 * current)), basewidth, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 180 * current);
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
    }
}
