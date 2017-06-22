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
using Windows.UI.Xaml.Navigation;

namespace Jaar_1_Project_4_Messages
{
    interface Message { }
    abstract class MessageFactory
    {
        public enum MessageType { question, answer, notification };
        public static Message Create(MessageType type)
        {
            switch (type)
            {
                case MessageType.question:
                    {
                        return new Question();
                    }
                case MessageType.answer:
                    {
                        return new Answer();
                    }
                case MessageType.notification:
                    {
                        return new Notification();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
    public class Question : Message
    {

    }
    public class Answer : Message
    {

    }
    public class Notification : Message
    {

    }
    public class EasyLabel
    {
        int width;
        int height;
        int x;
        int y;
        string text;
        dynamic current_page;
        public EasyLabel(int width, int height, int x, int y, string text, Page current_page)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.text = text;
            this.current_page = current_page;
        }
        public void draw()
        {
            var current_message = new TextBlock();
            current_message.Text = this.text;
            current_message.Width = this.width;
            current_message.Height = this.height;
            current_message.RenderTransform = new TranslateTransform { X = this.x, Y = this.y };
            this.current_page.Children.Add(current_message);
        }
    }
}
