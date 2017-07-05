using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

//Extends functionality the questionSystem

namespace Jaar_1_Project_4 {
    public abstract class QuestionExtender {
        private static string currentSelectedQuestionID; //For the queries, the text object name gets stored in
        private static int easyLabelCounter; //This is to edit the position of the texts, it gets incremented when the text are made
        private static bool isQuestion = true; //This is to have the question or answer text display next to the question or answer
        private static string theQuestion = ""; //To have it display in the textbox of the answer page
        public static string  CurrentSelectedQuestionID { get => currentSelectedQuestionID; set => currentSelectedQuestionID = value; }
        public static int EasyLabelCounter { get => easyLabelCounter; set => easyLabelCounter = value; }
        public static bool IsQuestion { get => isQuestion; set => isQuestion = value; }
        public static string TheQuestion { get => theQuestion; set => theQuestion = value; }

        //Checks if the selected question is answered, if it's not answered it is not allowed to be answered
        public static bool Isanswered() {
            PrepareForScreenQueryHandler prepareForScreenHandler = new PrepareForScreenQueryHandler();
            var syncClient = new HttpClient(); //To make connection with the API
            string teacherAnswer = "http://www.wschaijk.nl/api/api.php/SELECT-answer-FROM-answer-WHERE-question_id=" + "'" + currentSelectedQuestionID + "'; ";
            var teacherAnswerCall = syncClient.GetStringAsync(teacherAnswer); //Query gets done
            var teacherAnswerResult = teacherAnswerCall.Result; //Query result is saved

            string convertedTeacherAnswerResult = prepareForScreenHandler.ResultOnly(teacherAnswerResult);
            if(convertedTeacherAnswerResult == "This question is not yet answered.") {
                return false;
            }
            else {
                return true;
            }
        }
 
    }

}