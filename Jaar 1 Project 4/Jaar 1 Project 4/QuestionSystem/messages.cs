using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace Jaar_1_Project_4_Messages
{
    public interface Message
    {
        void Draw();
        EasyLabel content { get; }
        int content_y_value { set; }
        int margin { set; }
    }
    public enum MessageType { question, answer, notification } // this enum makes sure we can only create 3 kinds of in app messages 
    public abstract class MessageFactory
    {
        public static Message Create(MessageType type, EasyLabel text, Grid current_page, int margin) //current page is the grid the message has to be drawn to
        {
            switch (type) //checks the type of message you want and then returns the apropriate object
            {
                case MessageType.question:
                    {
                        return new Question(text, current_page, margin);
                    }
                case MessageType.answer:
                    {
                        return new Answer(text, current_page, margin);
                    }
                case MessageType.notification:
                    {
                        return new Notification(text, current_page, margin);
                    }
                default:
                    {
                        return null; //if there is no message we dont want an object 
                    }
            }
        }
    }
    public abstract class MessageDecorator : Message //this decorator adds text (an easy label) to your message
    {
        public EasyLabel message;
        public MessageDecorator(EasyLabel message)
        {
            this.message = message;
        }
        public abstract void Draw();
        public abstract EasyLabel content { get;}
        public abstract int content_y_value { set; }
        public abstract int margin { set; }
    }
    public class Question : MessageDecorator //if MessageType == question create a question message object(consisting of a colored background and text
    {
        bool IsAnswer;
        dynamic current_page;
        int some_margin;
        public Question(EasyLabel message, Grid current_page, int margin) : base(message)
        {
            this.IsAnswer = false;
            this.message = message;
            this.current_page = current_page;
            this.some_margin = margin;
        }

        public override EasyLabel content => this.message;

        public override int content_y_value { set => this.message.y = (int)value; }
        public override int margin { set => this.some_margin = value; }

        public override void Draw()
        {
            var background = new Rectangle();
            background.Fill = new SolidColorBrush(Windows.UI.Colors.LightPink);
            background.Width = this.message.getWidth() + 20;
            background.Height = 100;
            background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            background.VerticalAlignment = VerticalAlignment.Top;
            background.Margin = new Thickness(1, this.some_margin, 1, 1);
            background.StrokeThickness = 2;
            background.RadiusX = this.message.x;
            background.RadiusY = this.message.y;

            current_page.Children.Add(background);
            current_page.Children.Add(this.message.Draw());
            
            //first we create the background we want, then we draw that background and then we draw the text overtop to create a message with a colore background
        }
    }
    public class Answer : MessageDecorator //if MessageType == answer create an answer message object(consisting of a colored background (that differs from question) and text)
    {
        bool IsAnswer;
        dynamic current_page;
        int some_margin;

        public Answer(EasyLabel message, Grid current_page, int margin) : base(message)
        {
            this.IsAnswer = true;
            this.message = message;
            this.current_page = current_page;
            this.some_margin = margin;
        }

        public override EasyLabel content => this.message;

        public override int content_y_value { set => this.message.y = (int)value; }
        public override int margin { set => this.some_margin = value; }

        public override void Draw()
        {
            var background = new Rectangle();
            background.Fill = new SolidColorBrush(Windows.UI.Colors.White);
            background.Width = this.message.getWidth();
            background.Height = 100;
            background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            background.VerticalAlignment = VerticalAlignment.Top;
            background.Margin = new Thickness(1, this.some_margin, 1, 1);
            background.StrokeThickness = 2;
            background.RadiusX = 50;
            background.RadiusY = 10;

            current_page.Children.Add(background);
            current_page.Children.Add(this.message.Draw());
        }
    }
    public class Notification : MessageDecorator //if MessageType == notification create a notification message object(consisting of a colored background (that differs from question and answer) and text)
    {
        bool IsAnswer;
        dynamic current_page;
        int some_margin;

        public Notification(EasyLabel message, Grid current_page, int margin) : base(message)
        {
            this.current_page = current_page;
            this.IsAnswer = false;
            this.message = message;
            this.some_margin = margin;
        }

        public override EasyLabel content => this.message;

        public override int content_y_value { set => this.message.y = (int)value; }
        public override int margin { set => this.some_margin = value; }

        public override void Draw()
        {
            var background = new Rectangle();
            background.Fill = new SolidColorBrush(Windows.UI.Colors.DarkRed);
            background.Width = this.message.getWidth();
            background.Height = 180;
            background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            background.VerticalAlignment = VerticalAlignment.Top;
            background.Margin = new Thickness(1, this.some_margin, 1, 1);
            background.StrokeThickness = 2;
            background.RadiusX = 50;
            background.RadiusY = 10;

            current_page.Children.Add(background);
            current_page.Children.Add(this.message.Draw());
        }
    }
    public class EasyLabel //creates a textblock that can be drawn to the screen
    {
        public int x;
        public int y;
        string text;
        int width;
        int height;
        TextBlock current_message;
        public EasyLabel(int x, int y, int width, int height, string text)
        {
            this.x = x + width / 2 + 50;
            this.y = y;
            this.text = text;
            this.width = width;
            this.height = height;

            current_message = new TextBlock();
            current_message.TextWrapping = TextWrapping.Wrap;
            current_message.Text = this.text;
            current_message.Width = this.width;
            current_message.Height = this.height;
            current_message.RenderTransform = new TranslateTransform { X = this.x, Y = this.y };
        }
        public dynamic Draw() //returns the created textblock for the main classes (question, answer and notification) to use
        {
            return current_message;
        }
        public int getWidth() => this.width; //returns width of the textblock
        public double getHeight() => this.height; //returns height of the textblock
    }
}