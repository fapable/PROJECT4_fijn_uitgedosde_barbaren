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

//Class that has static methods so that it can be reached from the 3 activity pop up pages

namespace Jaar_1_Project_4 {
    public abstract class StaticActivityQueryMaker : Page {
        /* When a query is made, the results of the query's is set to these attributes below
         then the attributes (query results) can be reached by the 3 activity pop up pages
         to display the query results on the screen
        */
        private static string buttonName;
        private static string description;
        private static string eventName;
        private static string classroomID;
        private static string opleidingNaam;
        private static string duration;
        private static string startTime;
        private static string endTime;
        public static string ButtonName { get => buttonName; set => buttonName = value; }
        public static string Description { get => description; set => description = value; }
        public static string EventName { get => eventName; set => eventName = value; }
        public static string ClassroomID { get => classroomID; set => classroomID = value; }
        public static string OpleidingNaam { get => opleidingNaam; set => opleidingNaam = value; }
        public static string Duration { get => duration; set => duration = value; }
        public static string StartTime { get => startTime; set => startTime = value; }
        public static string EndTime { get => endTime; set => endTime = value; }

        //This method is to create the queries
        //As paramter is the clicked on event classroom
        public static void MakeQueries(string classroomId) {
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
            var descriptionResult = descriptionCall.Result; //Query result is sved

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
            StaticActivityQueryMaker.Description = descriptionResult;
            StaticActivityQueryMaker.EventName = eventResult;
            StaticActivityQueryMaker.ClassroomID = classroomIDResult;
            StaticActivityQueryMaker.OpleidingNaam = opleidingNaamResult;
            StaticActivityQueryMaker.Duration = durationResult;
            StaticActivityQueryMaker.StartTime = startTimeResult;
            StaticActivityQueryMaker.EndTime = endTimeResult;
        }

                /* These methods below create a textblock for each column from the DB
        As arguments is given the grid where it's drawn on, and the text (the query result)
        but before an SQL query result is drawn on the screen, it first gets converted.
        Why? Because the result has brackets and other things that are not nice to read
        They are removed in that method and the method then returns a: "prettier" querry result to read,
        and as final argument is given in which row the textblock needs to drawn
        it is comparable to Excel where you have columns and rows
        */
        public static void SetTextOnScreen(dynamic gridPage) {
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.OpleidingNaam), 1);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.ClassroomID), 2);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.EventName), 3);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.Description), 4);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.Duration), 5);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.StartTime), 6);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.EndTime), 7);
            AbstractGeneralQueryHandler.CreateTextBlock(gridPage, AbstractGeneralQueryHandler.ConvertRawQueryResultToNormalText(StaticActivityQueryMaker.ClassroomID), 8);
        }     
    }
}
