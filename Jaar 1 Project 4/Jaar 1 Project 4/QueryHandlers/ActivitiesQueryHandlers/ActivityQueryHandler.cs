﻿using System;
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

//Queries get prepared here 

namespace Jaar_1_Project_4 {
    public class ActivityQueryHandler : Page, IQueryHandler {
        public static CurrentFloor theCurrentFloor;
        public enum CurrentFloor  {secondfloor, thirdfloor, fourthfloor};  //Keeps track of the current floor
        private static string clickedOnEventRoom;
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

        //This method is to create the queries
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
       
            var descriptionCall = syncClient.GetStringAsync(description); //Query call
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

            //results set to the static set methods this is so they can by the 3 activity pop up pages
            ActivityQueryHandler.Description = descriptionResult;
            ActivityQueryHandler.EventName = eventResult;
            ActivityQueryHandler.ClassroomID = classroomIDResult;
            ActivityQueryHandler.OpleidingNaam = opleidingNaamResult;
            ActivityQueryHandler.Duration = durationResult;
            ActivityQueryHandler.StartTime = startTimeResult;
            ActivityQueryHandler.EndTime = endTimeResult;
        }

                /* These methods below create a textblock for each column from the DB
        As arguments is given the grid where it's drawn on, and the text (the query result)
        but before an SQL query result is drawn on the screen, it first gets converted.
        Why? Because the result has brackets and other things that are not nice to read
        They are removed in that method and the method then returns a: "prettier" querry result to read,
        and as final argument is given in which row the textblock needs to drawn
        it is comparable to Excel where you have columns and rows
        */
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
        //Method changes button name to a name that matches the DB tables
        public  string ChangeMainAttributeName(Object sender) {
            Button clickedOnButton = (Button) sender;
            string emptyButtonName = ""; //to store the buttonname
            foreach (var letter in clickedOnButton.Name.ToString()) {
                if (letter.ToString() == "_") { //for event buttons
                    emptyButtonName += ".";
                }
                else if (letter.ToString() == "-") { 
                    emptyButtonName += " ";
                }
                else {
                    emptyButtonName += letter.ToString();
                }
            }
            return emptyButtonName; //Buttoname gets SET so it can reached within the activity classses               
        }
    }
}