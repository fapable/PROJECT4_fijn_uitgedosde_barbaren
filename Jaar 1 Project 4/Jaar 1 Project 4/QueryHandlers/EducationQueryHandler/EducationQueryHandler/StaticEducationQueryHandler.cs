﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;

//Creates the queries for the education section (for all the wijnhavens)
//See the activityQueryHandler for the comments


namespace Jaar_1_Project_4 {
    public class EducationQueryHandler : IQueryHandler {
        public static CurrentWijnhaven theCurrentWijnhaven;
        public enum CurrentWijnhaven { wijnhaven61, wijnhaven99, wijnhaven103, wijnhaven107 };

        private static string education;
        private static string opleidinNaam;
        private static string description;
        private static string duration;
        private static string diplomaType;
        private static string jobs;

        IPrepareQueryForScreenDisplay displayOnScreenObject;
        public EducationQueryHandler() {
            this.displayOnScreenObject = new PrepareForScreenQueryHandler();

        }

        public static string Education { get => education; set => education = value; }
        public static string Description { get => description; set => description = value; }
        public static string Duration { get => duration; set => duration = value; }
        public static string DiplomaType { get => diplomaType; set => diplomaType = value; }
        public static string Jobs { get => jobs; set => jobs = value; }
        public static string OpleidinNaam { get => opleidinNaam; set => opleidinNaam = value; }
        public  CurrentWijnhaven CurrentWijnhavenGetSet { get => theCurrentWijnhaven; set => theCurrentWijnhaven = value; }



        public void MakeQueries(string education) {
            var syncClient = new HttpClient(); //To make connection with the API

            string opleidingNaam = "http://www.wschaijk.nl/api/api.php/SELECT-opleiding_naam-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string duration = "http://www.wschaijk.nl/api/api.php/SELECT-duration-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string diplomaType = "http://www.wschaijk.nl/api/api.php/SELECT-diploma_type-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string jobs = "http://www.wschaijk.nl/api/api.php/SELECT-jobs-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";

            var educationCall = syncClient.GetStringAsync(opleidingNaam);
            var educationResult = educationCall.Result;

            var descriptionCall = syncClient.GetStringAsync(description); //Query call
            var descriptionResult = descriptionCall.Result; //Query result is sved

            var durationCall = syncClient.GetStringAsync(duration);
            var durationResult = durationCall.Result;

            var diplomTypeCall = syncClient.GetStringAsync(diplomaType);
            var diplomaTypeResult = diplomTypeCall.Result;

            var jobsCall = syncClient.GetStringAsync(jobs);
            var jobsResult = jobsCall.Result;

            //results set to the static set methods
            EducationQueryHandler.opleidinNaam = educationResult;
            EducationQueryHandler.description = descriptionResult;
            EducationQueryHandler.duration = durationResult;
            EducationQueryHandler.diplomaType = diplomaTypeResult;
            EducationQueryHandler.jobs = jobsResult;
        }
        public void SetTextOnScreen(dynamic gridPage) {
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.opleidinNaam), 1);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.description), 2);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.duration), 3);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.diplomaType), 4);
            displayOnScreenObject.CreateTextBlock(gridPage, displayOnScreenObject.ConvertRawQueryResultToNormalText(EducationQueryHandler.jobs), 5);
        }
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
