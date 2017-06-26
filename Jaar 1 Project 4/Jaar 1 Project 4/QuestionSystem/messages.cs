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
    }
    public enum MessageType { question, answer }
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
            var backing = new Rectangle();
            backing.Fill = new SolidColorBrush(Color.FromArgb(0,0,0,255));
            backing.Width = 50;
            backing.Height = 50;
            //backing.Margin = new Thickness(50, 50, 0, 0);
            current_page.Children.Add(backing);
            current_page.Children.Add(this.message.Draw());
            //draw this.message overtop backing
        }
    }
    public class Answer : MessageDecorator
    {
        bool IsAnswer;
        public Answer(EasyLabel message, Grid current_page) : base(message)
        {
            this.IsAnswer = true;
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
        public EasyLabel(int x, int y, string text)
        {
            this.x = x;
            this.y = y;
            this.text = text;
        }
        public dynamic Draw()
        {
            var current_message = new TextBlock();
            //current_message.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            current_message.TextWrapping = TextWrapping.Wrap;
            current_message.Text = this.text;
            current_message.Width = 50;
            //current_message.Height = current_message.DesiredSize.Height;
            current_message.RenderTransform = new TranslateTransform { X = this.x, Y = this.y };
            return current_message;
        }
    }
}