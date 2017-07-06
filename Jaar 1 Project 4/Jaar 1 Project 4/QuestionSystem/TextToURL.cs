using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaar_1_Project_4.QuestionSystem
{
    class TextToURL
    {
        public static string text_to_string(string text)
        {
            string result = text;

            result = result.Replace("%", "%25");
            result = result.Replace(" ", "-");
            result = result.Replace("#", "%23");
            result = result.Replace("!", "%21");
            result = result.Replace("@", "%40");
            result = result.Replace("$", "%24");
            result = result.Replace("*", "%2A");
            result = result.Replace("+", "%2B");
            result = result.Replace("?", "");

            return result;
        }



    }
}
