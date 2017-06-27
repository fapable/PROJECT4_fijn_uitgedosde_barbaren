﻿using System;
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
    }
    public enum MessageType { question, answer, notification }
    public abstract class MessageFactory
    {
        public static Message Create(MessageType type, EasyLabel text, Grid current_page)
        {
            switch (type)
            {
                case MessageType.question:
                    {
                        return new Question(text, current_page);
                    }
                case MessageType.answer:
                    {
                        return new Answer(text, current_page);
                    }
                case MessageType.notification:
                    {
                        return new Notification(text, current_page);
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
    public abstract class MessageDecorator : Message
    {
        public EasyLabel message;
        public MessageDecorator(EasyLabel message)
        {
            this.message = message;
        }
        public abstract void Draw();
    }

    public class Question : MessageDecorator
    {
        bool IsAnswer;
        dynamic current_page;
        public Question(EasyLabel message, Grid current_page) : base(message)
        {
            this.IsAnswer = false;
            this.message = message;
            this.current_page = current_page;
        }
        public override void Draw()
        {
            var background = new Rectangle();
            background.Fill = new SolidColorBrush(Windows.UI.Colors.LightPink);
            background.Width = this.message.getWidth() - 70;
            background.Height = 180;
            background.Stroke = new SolidColorBrush(Windows.UI.Colors.Black);
            background.VerticalAlignment = VerticalAlignment.Top;
            background.Margin = new Thickness(30);
            background.StrokeThickness = 2;
            background.RadiusX = 50;
            background.RadiusY = 10;

            current_page.Children.Add(background);
            current_page.Children.Add(this.message.Draw());
            //draw this.message overtop backing
        }
    }
    public class Answer : MessageDecorator
    {
        bool IsAnswer;
        dynamic current_page;
        public Answer(EasyLabel message, Grid current_page) : base(message)
        {
            this.IsAnswer = true;
            this.message = message;
            this.current_page = current_page;
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
    public class Notification : MessageDecorator
    {
        bool IsAnswer;
        dynamic current_page;
        public Notification(EasyLabel message, Grid current_page) : base(message)
        {
            this.current_page = current_page;
            this.IsAnswer = false;
            this.message = message;
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
    public class EasyLabel
    {
        int x;
        int y;
        string text;
        int width;
        int height;
        TextBlock current_message;

        public EasyLabel(int x, int y, int width, string text)
        {
            this.x = x + width / 2 + 50;
            this.y = y;
            this.text = text;
            this.width = width;

            current_message = new TextBlock();
            current_message.TextWrapping = TextWrapping.Wrap;
            current_message.Text = this.text;
            current_message.Width = this.width;
            current_message.RenderTransform = new TranslateTransform { X = this.x, Y = this.y };
        }

        public dynamic Draw()
        {
            // Get variables
            current_message = new TextBlock();
            current_message.TextWrapping = TextWrapping.Wrap;
            current_message.Text = this.text;
            current_message.Text = this.getHeight().ToString();
            current_message.Width = this.width;
            current_message.RenderTransform = new TranslateTransform { X = this.x, Y = this.y };
            return current_message;
        }

        public int getWidth() => this.width;
        public double getHeight() => this.current_message.ActualHeight;
    }
}