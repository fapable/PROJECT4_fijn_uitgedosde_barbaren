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

namespace Jaar_1_Project_4_Messages
{
    public interface Message { }
    public abstract class MessageFactory
    {
        public enum MessageType { question, answer, notification };
        public static Message Create(MessageType type, EasyLabel text)
        {
            switch (type)
            {
                case MessageType.question:
                    {
                        return new Question(text);
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
    public abstract class MessageDecorator : Message
    {
        public EasyLabel message;
        public MessageDecorator(EasyLabel message)
        {
            this.message = message;
        }
    }
    public class Question : MessageDecorator
    {
        bool IsAnswer;
        public Question(EasyLabel message) : base(message)
        {
            this.IsAnswer = false;
            this.message = message;
        }
        public void Draw()
        {
            var backing = new Rectangle();
            backing.Fill = new SolidColorBrush(Color.FromArgb(0,0,0,0));
            
            //draw this.message overtop backing
        }
    }
    public class Answer : Message
    {
        bool IsAnswer;
        public Answer()
        {
            this.IsAnswer = true;
        }
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
