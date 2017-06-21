using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaar_1_Project_4
{
    interface Message { }
    abstract class MessageFactory
    {
        public enum MessageType { question, answer };
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
}
