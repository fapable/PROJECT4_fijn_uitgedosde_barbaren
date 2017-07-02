using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;

//See the activitiesQueryHandler for the comments

namespace Jaar_1_Project_4{
    public class ContactQueryHandler : IQueryHandler {
        private static string currentChoice;
        private static string questionType;
        private static string description;
        private static string number;
        private static string email;

        public static string CurrentChoice { get => currentChoice; set => currentChoice = value; }
        public static string QuestionType { get => questionType; set => questionType = value; }
        public static string Description { get => description; set => description = value; }
        public static string Number { get => number; set => number = value; }
        public static string Email { get => email; set => email = value; }

        IPrepareQueryForScreenDisplay displayOnScreenObject;
        public ContactQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();

        }
        public  void MakeQueries(string questionType) {
            var syncClient = new HttpClient(); //To make connection with the API

            string questiontype = "http://www.wschaijk.nl/api/api.php/SELECT-question_type-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";
            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";
            string number = "http://www.wschaijk.nl/api/api.php/SELECT-tel-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";
            string email = "http://www.wschaijk.nl/api/api.php/SELECT-email-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";

            var questiontypeCall = syncClient.GetStringAsync(questiontype);
            var questiontypeResult = questiontypeCall.Result;

            var descriptionCall = syncClient.GetStringAsync(description);
            var descriptionResult = descriptionCall.Result;

            var numberCall = syncClient.GetStringAsync(number);
            var numberResult = numberCall.Result;

            var emailCall = syncClient.GetStringAsync(email);
            var emailResult = emailCall.Result;

            //results set to the static set methods
            ContactQueryHandler.questionType = questiontypeResult;
            ContactQueryHandler.description = descriptionResult;
            ContactQueryHandler.number = numberResult;
            ContactQueryHandler.email = emailResult;

        }
        public void SetTextOnScreen(dynamic gridPage) {
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.questionType), 1);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.description), 2);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.number), 3);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.email), 4);
        }
        public string ChangeMainAttributeName(Object sender) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; 
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") { 
                    emptyButtonName += " ";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            return emptyButtonName;              
        }
    }
}