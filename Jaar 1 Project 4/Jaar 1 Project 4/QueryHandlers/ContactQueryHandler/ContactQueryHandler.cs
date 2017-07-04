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

//The main job of this class is to create queries and manipulate it, it also gives commandos to display the text (query result) on screen

namespace Jaar_1_Project_4 {
    public class ContactQueryHandler : IQueryHandler {
        private static string currentChoice; //This is the main attribute, the last clicked on button is stored, based on the button name the queries are made
        private static string questionType;
        private static string description;
        private static string number;
        private static string email;

        IPrepareQueryForScreenDisplay displayOnScreenObject; //To display the query results on the screen
        public ContactQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();
        }
        //Getters and setters
        public static string CurrentChoice { get => currentChoice; set => currentChoice = value; }
        public static string QuestionType { get => questionType; set => questionType = value; }
        public static string Description { get => description; set => description = value; }
        public static string Number { get => number; set => number = value; }
        public static string Email { get => email; set => email = value; }

        //The job of this method is to create queries, as paramters is the last clicked on contact button
        //Based on the button, the queries are made
        public void MakeQueries(string questionType) {
            var syncClient = new HttpClient(); //To make connection with the API

            string questiontype = "http://www.wschaijk.nl/api/api.php/SELECT-question_type-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";
            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";
            string number = "http://www.wschaijk.nl/api/api.php/SELECT-tel-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";
            string email = "http://www.wschaijk.nl/api/api.php/SELECT-email-FROM-contact-WHERE-question_type-=-" + "'" + questionType + "';";

            var questiontypeCall = syncClient.GetStringAsync(questiontype); //Query gets done
            var questiontypeResult = questiontypeCall.Result; //Query result is saved

            var descriptionCall = syncClient.GetStringAsync(description);
            var descriptionResult = descriptionCall.Result;

            var numberCall = syncClient.GetStringAsync(number);
            var numberResult = numberCall.Result;

            var emailCall = syncClient.GetStringAsync(email);
            var emailResult = emailCall.Result;

            //The attributes are set to the result of the query's, this is so that the result of the query can be shown on screen
            ContactQueryHandler.questionType = questiontypeResult;
            ContactQueryHandler.description = descriptionResult;
            ContactQueryHandler.number = numberResult;
            ContactQueryHandler.email = emailResult;

        }
        //This methods creates the textblock, and also calls a method that converts the raw query result to a better looking text
        //As parameter is the grid (page) on which the text (query results) should be drawn on
        public void SetTextOnScreen(dynamic gridPage) {
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.questionType), 1);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.description), 2);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.number), 3);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ContactQueryHandler.email), 4);
        }
        //Method changed the main attribute name to the last clicked on contact button, based on this main attribute the quries are made
        //This method is used because to have the main attribute name match the attribute from the DB
        //This method is called when an contact button is clicked
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