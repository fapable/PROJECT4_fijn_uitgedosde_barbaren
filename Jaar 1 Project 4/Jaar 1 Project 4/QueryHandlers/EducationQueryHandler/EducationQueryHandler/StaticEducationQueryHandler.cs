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
    public class EducationQueryHandler : IQueryHandler {
        public static CurrentWijnhaven theCurrentWijnhaven; //To keep track of the last selected wijnhaven
        public enum CurrentWijnhaven { wijnhaven61, wijnhaven99, wijnhaven103, wijnhaven107 };

        private static string education; //This is the main attribute, the last clicked on button is stored, based on the button name the queries are made
        private static string opleidinNaam;
        private static string description;
        private static string duration;
        private static string diplomaType;
        private static string jobs;

        IPrepareQueryForScreenDisplay displayOnScreenObject; //To display the query results on the screen
        public EducationQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();

        }
        //Getters and setters
        public static string Education { get => education; set => education = value; }
        public static string Description { get => description; set => description = value; }
        public static string Duration { get => duration; set => duration = value; }
        public static string DiplomaType { get => diplomaType; set => diplomaType = value; }
        public static string Jobs { get => jobs; set => jobs = value; }
        public static string OpleidinNaam { get => opleidinNaam; set => opleidinNaam = value; }
        public  CurrentWijnhaven CurrentWijnhavenGetSet { get => theCurrentWijnhaven; set => theCurrentWijnhaven = value; }

        //The job of this method is to create queries, as paramters is the last clicked on education button
        //Based on the button, the queries are made
        public void MakeQueries(string education) {
            var syncClient = new HttpClient(); //To make connection with the API

            string opleidingNaam = "http://www.wschaijk.nl/api/api.php/SELECT-opleiding_naam-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string duration = "http://www.wschaijk.nl/api/api.php/SELECT-duration-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string diplomaType = "http://www.wschaijk.nl/api/api.php/SELECT-diploma_type-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string jobs = "http://www.wschaijk.nl/api/api.php/SELECT-jobs-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";

            var educationCall = syncClient.GetStringAsync(opleidingNaam); //Query gets done
            var educationResult = educationCall.Result; //Result from the query is saved

            var descriptionCall = syncClient.GetStringAsync(description);
            var descriptionResult = descriptionCall.Result; 

            var durationCall = syncClient.GetStringAsync(duration);
            var durationResult = durationCall.Result;

            var diplomTypeCall = syncClient.GetStringAsync(diplomaType);
            var diplomaTypeResult = diplomTypeCall.Result;

            var jobsCall = syncClient.GetStringAsync(jobs);
            var jobsResult = jobsCall.Result;

            //The attributes are set to the result of the query's, this is so that the result of the query can be shown on screen
            EducationQueryHandler.opleidinNaam = educationResult;
            EducationQueryHandler.description = descriptionResult;
            EducationQueryHandler.duration = durationResult;
            EducationQueryHandler.diplomaType = diplomaTypeResult;
            EducationQueryHandler.jobs = jobsResult;
        }
        //This methods creates the textblock, and also calls a method that converts the raw query result to a better looking text
        //As parameter is the grid (page) on which the text (query results) should be drawn on
        public void SetTextOnScreen(dynamic gridPage) {
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.opleidinNaam), 1);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.description), 2);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.duration), 3);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.diplomaType), 4);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.jobs), 5);
        }
        //Method changed the main attribute name to the last clicked on education button, based on this main attribute the quries are made
        //This method is used because you cant have an object name with certain charachers, this method makes the button to match the DB attribute
        //The object name is then converted first
        //This method is called when an event education button is clicked
        public string ChangeMainAttributeName(Object sender) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the buttonname
            /*
            The foreach loop is here because you can't have object names with dots in UWP
            Since the database tables need to match the buttonname, the foreach loop is made to change (convert)
            the buttoname to match the DB tables
             */
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") { //for event buttons
                    emptyButtonName += " ";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            return emptyButtonName; //Buttoname gets SET so it can reached within SecondFloorPopup class                
        }
    }
}
