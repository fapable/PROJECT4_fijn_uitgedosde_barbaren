﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Windows.Foundation;
using Jaar_1_Project_4;

namespace Jaar_1_Project_4_Messages {
    public interface Message {
        void Draw();
        EasyLabel Content { get; }
        EasyLabel SecondContent { get; }
        int Content_y_value { set; }
        int Margin { set; }
        int GetQuestionID { get; } //To get the question ID
        void SecondDraw();
    }
    public enum MessageType { question, answer, notification } // this enum makes sure we can only create 3 kinds of in app messages 
    public abstract class MessageFactory {
        public static Message Create(MessageType type, EasyLabel text, Grid current_page, int margin, string email, string name, int qandaid, string education, EasyLabel easylabel = null) //current page is the grid the message has to be drawn to
        {
            switch (type) //checks the type of message you want and then returns the apropriate object
            {
                case MessageType.question: {
                        return new Question(text, current_page, margin, email, name, qandaid, education, easylabel);
                    }
                case MessageType.answer: {
                        return new Answer(text, current_page, margin, name, qandaid, education);
                    }
                case MessageType.notification: {
                        return new Notification(text, current_page, margin);
                    }
                default: {
                        return null; //if there is no message we dont want an object 
                    }
            }
        }
    }
    public abstract class MessageDecorator : Message //this decorator adds text (an easy label) to your message
    {
        public EasyLabel message;
        public int qandaid;
        public string education;
        public MessageDecorator(EasyLabel message, int qandaid, string education) {
            this.message = message;
            this.qandaid = qandaid;
            this.education = education;
        }
        public abstract void Draw();
        public abstract void SecondDraw();

        public abstract EasyLabel Content { get; }
        public abstract int Content_y_value { set; }
        public abstract int Margin { set; }
        public abstract int GetQuestionID { get; }
        public abstract EasyLabel SecondContent { get; }
    }
    public class Question : MessageDecorator //if MessageType == question create a question message object(consisting of a colored background and text
    {
        bool IsAnswer;
        dynamic current_page;
        int some_margin;
        string email;
        string name;
        EasyLabel secondEasyLabel;

        public Question(EasyLabel message, Grid current_page, int margin, string email, string name, int qandaid, string education, EasyLabel easylabel = null) : base(message, qandaid, education) {
            this.IsAnswer = false;
            this.message = message;
            this.current_page = current_page;
            this.some_margin = margin;
            this.email = email;
            this.name = name;
            this.secondEasyLabel = easylabel;
        }

        public override EasyLabel Content => this.message;

        public override int Content_y_value { set => this.message.y = (int) value; }
        public override int Margin { set => this.some_margin = value; }

        public override int GetQuestionID => base.qandaid;

        public override EasyLabel SecondContent => this.secondEasyLabel;

        public override void Draw() {
            ////var background = new Rectangle();
            ////background.Fill = new SolidColorBrush(Windows.UI.Colors.LightPink);
            ////background.Width = this.message.GetWidth() + 20;
            ////background.Height = 100;
            ////background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            ////background.VerticalAlignment = VerticalAlignment.Top;
            ////background.Margin = new Thickness(1, this.some_margin, 1, 1);
            ////background.StrokeThickness = 2;
            ////background.RadiusX = this.message.x;
            ////background.RadiusY = this.message.y;
            //current_page.Children.Add(background);
            this.message.Foreground = new SolidColorBrush(Colors.Navy);
            current_page.Children.Add(this.message.Draw());

            //first we create the background we want, then we draw that background and then we draw the text overtop to create a message with a colore background
        }

        public override void SecondDraw() {
            current_page.Children.Add(this.secondEasyLabel.Draw());
        }
    }
    public class Answer : MessageDecorator //if MessageType == answer create an answer message object(consisting of a colored background (that differs from question) and text)
    {
        bool IsAnswer;
        dynamic current_page;
        int some_margin;
        string teacherid;

        public Answer(EasyLabel message, Grid current_page, int margin, string teacherid, int qandaid, string education) : base(message, qandaid, education) {
            this.IsAnswer = true;
            this.message = message;
            this.current_page = current_page;
            this.some_margin = margin;
            this.teacherid = teacherid;
        }

        public override EasyLabel Content => this.message;

        public override int Content_y_value { set => this.message.y = (int) value; }
        public override int Margin { set => this.some_margin = value; }

        public override int GetQuestionID => base.qandaid;

        public override EasyLabel SecondContent => throw new NotImplementedException();

        public override void Draw() {
            //var background = new Rectangle();
            //background.Fill = new SolidColorBrush(Windows.UI.Colors.White);
            //background.Width = this.message.GetWidth();
            //background.Height = 100;
            //background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            //background.VerticalAlignment = VerticalAlignment.Top;
            //background.Margin = new Thickness(1, this.some_margin, 1, 1);
            //background.StrokeThickness = 2;
            //background.RadiusX = 50;
            //background.RadiusY = 10;

            //current_page.Children.Add(background);
            current_page.Children.Add(this.message.Draw());
        }

        public override void SecondDraw() {
            throw new NotImplementedException();
        }
    }
    public class Notification : MessageDecorator //if MessageType == notification create a notification message object(consisting of a colored background (that differs from question and answer) and text)
    {
        bool IsAnswer;
        dynamic current_page;
        int some_margin;

        public Notification(EasyLabel message, Grid current_page, int margin) : base(message, -1, null) {
            this.current_page = current_page;
            this.IsAnswer = false;
            this.message = message;
            this.some_margin = margin;
        }

        public override EasyLabel Content => this.message;

        public override int Content_y_value { set => this.message.y = (int) value; }
        public override int Margin { set => this.some_margin = value; }

        public override int GetQuestionID => base.qandaid;

        public override EasyLabel SecondContent => throw new NotImplementedException();

        public override void Draw() {
            //var background = new Rectangle();
            //background.Fill = new SolidColorBrush(Windows.UI.Colors.DarkRed);
            //background.Width = this.message.GetWidth();
            //background.Height = 180;
            //background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            //background.VerticalAlignment = VerticalAlignment.Top;
            //background.Margin = new Thickness(1, this.some_margin, 1, 1);
            //background.StrokeThickness = 2;
            //background.RadiusX = 50;
            //background.RadiusY = 10;

            //current_page.Children.Add(background);
            current_page.Children.Add(this.message.Draw());
        }

        public override void SecondDraw() {
            throw new NotImplementedException();
        }
    }
    public class EasyLabel : Page//creates a textblock that can be drawn to the screen
    {
        public int x;
        public int y;
        public string text;
        int width;
        int height;
        public TextBlock current_message;
        public TextBlock hiddenTextBlockID;

        public EasyLabel(int x, int y, int width, int height, string text, string hiddenParameterID = "HELLLOOOOOOOOOOOOOOOOOOOOOOOO") {
            this.x = x + width / 2 + 50;
            this.y = y;
            this.text = text;
            this.width = width;
            this.height = height;


            current_message = new TextBlock();
            current_message.TextWrapping = TextWrapping.Wrap;

            //puts the answer or question title in front of the answer or question
            if (QuestionExtender.IsQuestion == true) {
                current_message.Text = "Question" + QuestionExtender.CurrentSelectedQuestionID.ToString() + ": " + this.text;

            }
            else {
                current_message.Text = "Answer" + QuestionExtender.CurrentSelectedQuestionID.ToString() + ": " + this.text;

            }

            current_message.Name = QuestionExtender.CurrentSelectedQuestionID.ToString(); //Important, object name gets set to the current ID
            current_message.HorizontalAlignment = HorizontalAlignment.Center;
            current_message.Margin = new Thickness(10, QuestionExtender.EasyLabelCounter, 0, 0); //Important, questionExtender increments, the position changes based on it

            //current_message.Width = this.width;
            //current_message.Height = this.height;
            //current_message.RenderTransform = new TranslateTransform { X = this.x, Y = this.y };

            if (DatabaseLoginCheck.IsTeacherLoggedInGetAndSettter) {
                //this.current_message.Tapped += new TappedEventHandler(answerQuestion);
            }
        }
        public dynamic Draw() //returns the created textblock for the main classes (question, answer and notification) to use
        {
            return current_message;
        }

        //public bool answerQuestion(object sender, TappedRoutedEventArgs e)
        //{
        //    return true;
        //}

        public int GetWidth() => this.width; //returns width of the textblock
        public double GetHeight() => this.height; //returns height of the textblock
    }
}