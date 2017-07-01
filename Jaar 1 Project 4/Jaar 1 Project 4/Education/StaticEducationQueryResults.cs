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

//Creates the queries for the education section (for all the wijnhavens)
//TODO finish the class

namespace Jaar_1_Project_4 {
    public abstract class StaticEducationQueryResults {
        public enum currentEducation { Communicatie, CommunicationAndMultimediaDesign,CreativeMediaAndGameTechnologies,Informatica,
        LeisureManagement,TechnicalInformatica}

        private static string education;
        private static string description;
        private static string duration;
        private static string diplomaType;
        private static string jobs;

        public static string Education { get => education; set => education = value; }
        public static string Description { get => description; set => description = value; }
        public static string Duration { get => duration; set => duration = value; }
        public static string DiplomaType { get => diplomaType; set => diplomaType = value; }
        public static string Jobs { get => jobs; set => jobs = value; }
       

        public static void MakeQueries(string education) {
            var syncClient = new HttpClient(); //To make connection with the API

            string description = "http://www.wschaijk.nl/api/api.php/SELECT-description-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string duration = "http://www.wschaijk.nl/api/api.php/SELECT-duration-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string diplomaType = "http://www.wschaijk.nl/api/api.php/SELECT-diploma_type-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";
            string jobs = "http://www.wschaijk.nl/api/api.php/SELECT-jobs-FROM-opleiding-WHERE-opleiding_naam-=-" + "'" + education + "';";

            var descriptionCall = syncClient.GetStringAsync(description); //Query call
            var descriptionResult = descriptionCall.Result; //Query result is sved

            var durationCall = syncClient.GetStringAsync(duration); 
            var durationResult = durationCall.Result; 

            var diplomTypeCall = syncClient.GetStringAsync(diplomaType); 
            var diplomaTypeResult = diplomTypeCall.Result; 

            var jobsCall = syncClient.GetStringAsync(jobs); 
            var jobsResult = jobsCall.Result;

            //results set to the static set methods
            StaticEducationQueryResults.description = descriptionResult;
            StaticEducationQueryResults.duration = durationResult;
            StaticEducationQueryResults.diplomaType = diplomaTypeResult;
            StaticEducationQueryResults.jobs = jobsResult;
        } 
      
    }
}
