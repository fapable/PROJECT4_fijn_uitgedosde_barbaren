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
using System.Net.Http;
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
            var syncClient = new HttpClient(); //To make connection with the API
            //The queries
            string questionquery = "http://www.wschaijk.nl/api/api.php/SELECT-*-FROM-questions";
            string answerquery = "http://www.wschaijk.nl/api/api.php/SELECT-*-FROM-answer-ORDER-BY-question_id";

            var questionqueryCall = syncClient.GetStringAsync(questionquery); //Query gets done
            var questionqueryResult = questionqueryCall.Result; //Query result is saved
            var answerqueryCall = syncClient.GetStringAsync(answerquery);
            var answerqueryresult = answerqueryCall.Result;

            List<List<string>> results = create_array_from_string(questionqueryResult, answerqueryresult);

            int someothercount = 0;
            foreach(List<string> entry in results)
            {
                someothercount++;
                if (someothercount % 2 != 0)
                {
                    Debug.WriteLine(entry[0] + entry[4]);
                } else
                {
                    Debug.WriteLine(entry[0] + entry[3]);
                }
            }

            int basex = -360;
            int basey = -(GetHeight());//-700; //het probleem is hij pak het midden van de scrollable pagina 
            int basewidth = 640;
            int baseheieght = 80;
            List<Message> current_messages = new List<Message> { };
            List<List<string>> answerHold = new List<List<string>>();
            int count = 0;
            int previousID = -125678;
            foreach (List<string> entry in results)
            {
                
                if (entry.Count == 5)
                {
                    Message current_message = MessageFactory.Create(MessageType.question, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * count)), GetWidth() - 100, baseheieght, entry[4]), current_page, (30 * (count + 1)) + 100 * count, entry[2], entry[3], Int32.Parse(entry[0]), entry[1]);
                    if (DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter) { current_message.Content.current_message.Tapped += new TappedEventHandler(answerQuestion); }
                    current_message.Draw();
                    current_messages.Add(current_message);
                    previousID = Int32.Parse(entry[0]);
                    count++;
                } else
                {
                   Message current_message = MessageFactory.Create(MessageType.answer, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * count)), GetWidth() - 70, baseheieght, entry[3]), current_page, (30 * (count + 1)) + 100 * count, null, "leraar", 1, "informatica");
                    current_message.Draw();
                    count++;
                    current_messages.Add(current_message);
                }
                //if (entry.Count == 4) { 
                //    answerHold.Add(entry);
                    
                //}
                //if (answerHold.Count != 0)
                //{
                //    if (previousID == Int32.Parse(answerHold[0][0]))
                //    {
                //        Message current_message = MessageFactory.Create(MessageType.answer, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * count)), GetWidth() - 70, baseheieght, answerHold[0][3]), current_page, (30 * (count + 1)) + 100 * count, null, "leraar", 1, "informatica");
                //        current_message.Draw();
                //        count++;
                //        current_messages.Add(current_message);
                //    }
                //}
            }

            //for(int current = 0; current < qena.Count(); current++)
            //{
            //    if(current % 2 == 0)
            //    {
            //        Message current_message = MessageFactory.Create(MessageType.question, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * current)), GetWidth() - 100, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 100 * current, "test", "Henk", 1, "informatica");
            //        if (DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter) { current_message.Content.current_message.Tapped += new TappedEventHandler(answerQuestion); }
            //        current_message.Draw();
            //        current_messages.Add(current_message);
            //    }
            //    else if(current % 2 != 0)
            //    {
            //        Message current_message = MessageFactory.Create(MessageType.answer, new EasyLabel(0 - (GetWidth() / 2), (basey + (130 * current)), GetWidth() - 70, baseheieght, qena[current]), current_page, (30 * (current + 1)) + 100 * current, null, "leraar", 1, "informatica");
            //        current_message.Draw();
            //        current_messages.Add(current_message);
            //    }
            //}
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
        private int GetHeight()
        {
            Rect dimensions = Window.Current.Bounds;
            return (int)dimensions.Height/5 * 4;
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(Jaar_1_Project_4.QuestionSystem.mainQpage));
        }

        public void answerQuestion(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("Clicked It Bitch");
            this.Frame.Navigate(typeof(Answer));
        }
        public List<List<string>> create_array_from_string(string questions, string answers)
        {
            List<List<String>> result = new List<List<string>>();
            int count_answers = 0;
            int count_questions = 0;
            Boolean scanning = false;
            string current = "";
            List<string> questionstrings = new List<string>();
            List<string> answerstrings = new List<string>();

            // Count the ammount of questions and create an array of strings
            foreach(char character in questions)
            {
                if(character == '{')
                {
                    count_questions++;
                    scanning = true;
                }

                if(scanning)
                {
                    current += character;
                }

                if(character == '}')
                {
                    scanning = false;
                    questionstrings.Add(current);
                    current = "";
                }
            }

            // Count the ammount of answers
            foreach (char character in answers)
            {
                if (character == '{')
                {
                    count_answers++;
                    scanning = true;
                }

                if (scanning)
                {
                    current += character;
                }

                if (character == '}')
                {
                    scanning = false;
                    answerstrings.Add(current);
                    current = "";
                }
            }

            List<string> finalquestions = new List<string>();
            List<string> finalanswers = new List<string>();
            int count = 0;

            // Get the information required out of the strings
            for(int i = 0; i <= count_questions - 1; i++)
            {
                foreach(char character in questionstrings[i])
                {
                    if(character == '"')
                    {
                        count++;
                        if(count == 3)
                        {
                            scanning = true;
                        }
                    }

                    if(scanning && character != '"')
                    {
                        current += character;
                    }

                    if(count == 4)
                    {
                        scanning = false;
                        finalquestions.Add(current);
                        current = "";
                        count = 0;
                    }
                }

                result.Add(finalquestions);
                finalquestions = new List<string>();
                count = 0;

                if (i <= count_answers - 1)
                {
                    count = 0;
                    foreach (char character in answerstrings[i])
                    {
                        if (character == '"')
                        {
                            count++;
                            if (count == 3)
                            {
                                scanning = true;
                            }
                        }

                        if (scanning && character != '"')
                        {
                            current += character;
                        }

                        if (count == 4)
                        {
                            scanning = false;
                            finalanswers.Add(current);
                            current = "";
                            count = 0;
                        }
                    }

                    result.Add(finalanswers);
                    finalanswers = new List<string>();
                    count = 0;
                }
            }
                
            return result;
        }
    }
}
