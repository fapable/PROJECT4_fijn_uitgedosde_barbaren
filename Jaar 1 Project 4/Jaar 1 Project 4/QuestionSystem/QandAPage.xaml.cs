using System;
using System.Diagnostics;
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
using Jaar_1_Project_4;


namespace Jaar_1_Project_4.QuestionSystem
{

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
            List<Message> current_messages = new List<Message> { };
            for(int current = 0; current < qena.Count(); current++)
            {
                if(current % 2 == 0)
                {
                    Message current_message = MessageFactory.Create(MessageType.question, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * current)), GetWidth() - 100, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 100 * current, "test", "Henk", 1, "informatica");
                    if (DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter) { current_message.Content.current_message.Tapped += new TappedEventHandler(answerQuestion); }
                    current_message.Draw();
                    current_messages.Add(current_message);
                }
                else if(current % 2 != 0)
                {
                    Message current_message = MessageFactory.Create(MessageType.answer, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * current)), GetWidth() - 70, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 100 * current, null, "leraar", 1, "informatica");
                    current_message.Draw();
                    current_messages.Add(current_message);
                }
            }
            //foreach(Message thing in current_messages)
            //{
            //    EasyLabel label = thing.content;
            //    if(label.answerQuestion())
            //    {

            //    }
            //}
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mainQpage));
        }
        private int GetWidth()
        {
            Rect dimensions = Window.Current.Bounds;
            return (int)dimensions.Width - 100;
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }

        public void answerQuestion(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("Clicked It Bitch");
            this.Frame.Navigate(typeof(Answer));
        }
    }
}
