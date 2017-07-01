using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;




//Saves the buttonname and the result of the query's
//Then these attributes get approached to draw it to the screen (text)
//This method is used for the activity section of the application
namespace Jaar_1_Project_4 {
    public abstract class StaticActivityQueryMaker : Page {
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

        //This method is to create queries
        public static void MakeQueries(string classroomId) {
            var syncClient = new HttpClient(); //Webclient does not work for windows universal platform

            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string eventName = "http://www.wschaijk.nl/api/api.php/SELECT-event_name-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string classRoomID = "http://www.wschaijk.nl/api/api.php/SELECT-classroom_id-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string opleidingNaam = "http://www.wschaijk.nl/api/api.php/SELECT-opleiding_naam-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string duration = "http://www.wschaijk.nl/api/api.php/SELECT-duration-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string startTime = "http://www.wschaijk.nl/api/api.php/SELECT-start_time-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";
            string endTime = "http://www.wschaijk.nl/api/api.php/SELECT-end_time-FROM-events-WHERE-classroom_ID-=-" + "'" + classroomId + "';";

            var descriptionCall = syncClient.GetStringAsync(description);
            var descriptionResult = descriptionCall.Result;

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

            //results get set to the static set methods this is so they can be reached everywhere in the program
            StaticActivityQueryMaker.Description = descriptionResult;
            StaticActivityQueryMaker.EventName = eventResult;
            StaticActivityQueryMaker.ClassroomID = classroomIDResult;
            StaticActivityQueryMaker.OpleidingNaam = opleidingNaamResult;
            StaticActivityQueryMaker.Duration = durationResult;
            StaticActivityQueryMaker.StartTime = startTimeResult;
            StaticActivityQueryMaker.EndTime = endTimeResult;
        }
        //To create the text (query results) that will appear on the screen
        public static void CreateTextBlock(dynamic gridPage, string queryResult, int gridRow) {
            TextBlock textblock = new TextBlock();
            textblock.Text = queryResult;
            Grid.SetColumn(textblock, 0);
            Grid.SetRow(textblock, gridRow);
            textblock.VerticalAlignment = VerticalAlignment.Center; //Without this the application freezes
            textblock.TextWrapping = TextWrapping.Wrap; //this way the text won't go out of the screen
            textblock.FontSize = 20;
            textblock.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            textblock.FontWeight = FontWeights.Bold;
            gridPage.Children.Add(textblock);
        } 
       
    }
}
