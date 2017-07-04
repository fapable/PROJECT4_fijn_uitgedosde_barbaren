using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;

//The main job of this class is to create queries and manipulate it, it also gives commandos to display the text (query result) on screen

namespace Jaar_1_Project_4 {
    public class ActivityQueryHandler : Page, IQueryHandler {
        public static CurrentFloor theCurrentFloor; //To keep track of the last selected floor
        public enum CurrentFloor  {secondfloor, thirdfloor, fourthfloor};  
        private static string clickedOnEventRoom; //This is the main attribute, the last clicked on button is stored, based on the button name the queries are made
        private static string description;
        private static string eventName;
        private static string classroomID;
        private static string opleidingNaam;
        private static string duration;
        private static string startTime;
        private static string endTime;

        IPrepareQueryForScreenDisplay displayOnScreenObject; //To display the query results on the screen
        public ActivityQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();

        }
        //Getters and setters
        public string ButtonName { get => clickedOnEventRoom; set => clickedOnEventRoom = value; }
        public static string Description { get => description; set => description = value; }
        public static string EventName { get => eventName; set => eventName = value; }
        public static string ClassroomID { get => classroomID; set => classroomID = value; }
        public static string OpleidingNaam { get => opleidingNaam; set => opleidingNaam = value; }
        public static string Duration { get => duration; set => duration = value; }
        public static string StartTime { get => startTime; set => startTime = value; }
        public static string EndTime { get => endTime; set => endTime = value; }
        public  CurrentFloor CurrentFloorGetSet { get => theCurrentFloor; set => theCurrentFloor = value; }

        //The job of this method is to create queries, as paramters is the last clicked on eventroom button
        //Based on the button, the queries are made
        public void MakeQueries(string classroomId) {
            var syncClient = new HttpClient(); //To make connection with the API

            //The queries
            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string eventName = "http://www.wschaijk.nl/api/api.php/SELECT-event_name-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string classRoomID = "http://www.wschaijk.nl/api/api.php/SELECT-classroom_id-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string opleidingNaam = "http://www.wschaijk.nl/api/api.php/SELECT-opleiding_naam-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string duration = "http://www.wschaijk.nl/api/api.php/SELECT-duration-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string startTime = "http://www.wschaijk.nl/api/api.php/SELECT-start_time-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string endTime = "http://www.wschaijk.nl/api/api.php/SELECT-end_time-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
       
            var descriptionCall = syncClient.GetStringAsync(description); //Query gets done
            var descriptionResult = descriptionCall.Result; //Query result is saved

            var eventCall = syncClient.GetStringAsync(eventName);
            var eventResult = eventCall.Result;         

            var classroomidCall = syncClient.GetStringAsync(classRoomID);
            var classroomIDResult = classroomidCall.Result;

            var opleidingnaamCall = syncClient.GetStringAsync(opleidingNaam);
            var opleidingNaamResult = opleidingnaamCall.Result;

            var durationCall = syncClient.GetStringAsync(duration);
            var durationResult = durationCall.Result;

            var startTimeCall = syncClient.GetStringAsync(startTime);
            var startTimeResult = startTimeCall.Result;

            var endTimeCall = syncClient.GetStringAsync(endTime);
            var endTimeResult = endTimeCall.Result;

            //The attributes are set to the result of the query's, this is so that the result of the query can be shown on screen
            ActivityQueryHandler.Description = descriptionResult;
            ActivityQueryHandler.EventName = eventResult;
            ActivityQueryHandler.ClassroomID = classroomIDResult;
            ActivityQueryHandler.OpleidingNaam = opleidingNaamResult;
            ActivityQueryHandler.Duration = durationResult;
            ActivityQueryHandler.StartTime = startTimeResult;
            ActivityQueryHandler.EndTime = endTimeResult;
        }
        //This methods creates the textblock, and also calls a method that converts the raw query result to a better looking text
        //As parameter is the grid (page) on which the text (query results) should be drawn on
        public void SetTextOnScreen(dynamic gridPage) {
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.OpleidingNaam), 1);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.ClassroomID), 2);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.EventName), 3);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.Description), 4);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.Duration), 5);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.StartTime), 6);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.EndTime), 7);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(ActivityQueryHandler.ClassroomID), 8);
        }
        //Method changed the main attribute name to the last clicked on event button, based on this main attribute the quries are made
        //This method is used because you cant have an object name with dots, but since the attributes in the DB do have dots
        //The object name is then converted first
        //This method is called when an event room button is clicked
        public  string ChangeMainAttributeName(Object sender) {
            Button clickedOnButton = (Button) sender; 
            string emptyButtonName = ""; //to store the buttonname
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") {
                    emptyButtonName += ".";
                }
                else if (letter.ToString() == "-") { 
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
